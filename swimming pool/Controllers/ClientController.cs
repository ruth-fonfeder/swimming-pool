using Clean.Core.Services;
using Microsoft.AspNetCore.Mvc;
using swimming_pool.Entities;
//using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace swimming_pool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public IEnumerable<Client> GetClient()
        {
            return _clientService.Clients;
        }

        [HttpGet("{id:int}")]
        public ActionResult Get(int id)
        {
            var c1 = _clientService.Clients.FirstOrDefault(s => s.ClientID == id);
            if (c1 == null)
                return NotFound("Client with: " + id + " not found");
            else return Ok(c1);
        }

        [HttpGet("name/{name}")]
        public ActionResult Get(string name)
        {
            var cf = _clientService.Clients.FirstOrDefault(s => s.FirstName == name);

            if (cf == null)
                return NotFound("Client with: " + name + " not found");
            else return Ok(cf);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Client c)
        {
            if (c != null)
            {
                _clientService.Clients.Add(c);
                return Ok(c);
            }
            return NotFound(null);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Client c)
        {
            var changec = _clientService.Clients.FirstOrDefault(cl => cl.ClientID == id);
            if (changec == null)
                return NotFound(id);
            else
            {
                changec.FirstName = c.FirstName;
                changec.LastName = c.LastName;
                changec.Email = c.Email;
                changec.PhoneNumber = c.PhoneNumber;
                changec.Age = c.Age;
                return Ok(changec);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var c = _clientService.Clients.FirstOrDefault(s => s.ClientID == id);
            if (c == null)
                return NotFound(id);
            else
            {
                _clientService.Clients.Remove(c);
                return Ok(c);
            }

        }
    }
}
