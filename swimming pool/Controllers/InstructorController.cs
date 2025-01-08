using Microsoft.AspNetCore.Mvc;
using swimming_pool.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace swimming_pool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorController : ControllerBase
    {
        private readonly static DataContext data=new DataContext();
        [HttpGet]
        public IEnumerable<Instructor> Get()
        {
            return data.instructors;
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var c1 = data.instructors.FirstOrDefault(c2 => c2.InstructorID == id);
            if (c1 != null)
                return Ok(c1);
            else
                return NotFound(id);
        }
        [HttpGet("name/{name}")]
        public ActionResult Get(string name)
        {
            var cf = data.instructors.FirstOrDefault(s => s.FirstName == name);

            if (cf == null)
                return NotFound("Client with" + name + " not found");
            else return Ok(cf);
        }
        [HttpPost]
        public ActionResult Post([FromBody] Instructor c1)
        {
            if (c1 != null)
            {
                data.instructors.Add(c1);
                return Ok(c1);
            }
            return NotFound(c1);

        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Instructor c)
        {
            var changC = data.instructors.FirstOrDefault(c2 => c2.InstructorID == id);
            if (changC != null)
            {
                changC.InstructorID=c.InstructorID;
                changC.Certifications = c.Certifications;
                changC.PhoneNumber = c.PhoneNumber;
                changC.FirstName = c.FirstName;
                changC.Level = c.Level;
                changC.LastName = c.LastName;
                changC.Availability = c.Availability;
                return Ok(changC);
            }
            return NotFound(id);
        }

        // DELETE api/<InstructorController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var d = data.instructors.FirstOrDefault(d2 => d2.InstructorID== id);
            if (d != null)
            {
                data.instructors.Remove(d);
                return Ok(d);
            }
            return NotFound(id);
        }
    }
}
