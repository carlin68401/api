using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        [Route("getStudents")]
        public async Task<ActionResult<Student>> GetStudents()
        {
            var students = new List<Student>()
            {
                new Student()
                {
                    id= 1,
                    name= "carlin dev",
                   age=30,
                   city= "nova odessa"
                },
                {
                new Student()
                {
                    id= 2,
                    name= "jao dev",
                   age=40,
                   city= "nova odessa"
                }

        }
        };
            return Ok(students);
    }
    }
}
