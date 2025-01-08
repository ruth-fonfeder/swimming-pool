using Microsoft.AspNetCore.Mvc;
using swimming_pool.Entities;
//using swimming_pool.Entities;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace swimming_pool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursController : ControllerBase
    {
        private readonly  ClientService
        [HttpGet]
        public IEnumerable<Course> Get()
        {
            return data.courses;
        }
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
           var c1=data.courses.FirstOrDefault(c2=>c2.CourseID==id);
            if (c1 != null)
                return Ok(c1);
            else
                return NotFound(id);
        }
        [HttpGet("Type/{Type}")]
        public ActionResult Get(string t)
        {
            var t1 = data.courses.FirstOrDefault(c2 => c2.type == t);
            if (t1 != null)
                return Ok(t1);
            else
                return NotFound(t);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Course c1)
        {
            if (c1 != null)
            {
                data.courses.Add(c1);
                return Ok(c1);
            }
            return NotFound(c1);
            
        }
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Course c)
        {
            var changC= data.courses.FirstOrDefault(c2=>c2.CourseID == id);
            if (changC != null)
            {
                changC.CourseID = c.CourseID;
                changC.Description = c.Description;
                changC.type = c.type;
                changC.SessionDuration = c.SessionDuration;
                changC.Level = c.Level;
                changC.Price = c.Price;
               changC.InstructorID = c.InstructorID;
                return Ok(changC);
            }
            return NotFound(id);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var d= data.courses.FirstOrDefault(d2 => d2.CourseID == id);
            if(d != null)
            {
                data.courses.Remove(d);
                return Ok(d);
            }
            return NotFound(id);
        }
    }
}
