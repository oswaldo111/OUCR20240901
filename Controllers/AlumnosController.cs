using Microsoft.AspNetCore.Mvc;
using OUCR20240901.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OUCR20240901.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase
    {

        static List<Alumnos> alumnos =  new List<Alumnos>();
        // GET: api/<AlumnosController>
        [HttpGet]
        public IEnumerable<Alumnos> Get()
        {
            return alumnos;
        }

        // GET api/<AlumnosController>/5
        [HttpGet("{id}")]
        public Alumnos Get(int id)
        {
            var alumno = alumnos.FirstOrDefault(x => x.Id == id);
            return alumno;
        }

        // POST api/<AlumnosController>
        [HttpPost]
        public IActionResult Post([FromBody] Alumnos alumn)
        {
            alumnos.Add(alumn);
            return Ok();
        }

        // PUT api/<AlumnosController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Alumnos alumno)
        {
            var existingAlumno = alumnos.FirstOrDefault(y => y.Id == id);
            if (existingAlumno != null)
            {
                existingAlumno.Name = alumno.Name;
                existingAlumno.Lastname = alumno.Lastname;
                return Ok();
            }
            else return NotFound();
        }

        // DELETE api/<AlumnosController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingAlumno = alumnos.FirstOrDefault(c => c.Id == id);
            if (existingAlumno != null)
            {
                alumnos.Remove(existingAlumno);
                return Ok();
            }
            else return NotFound();
        }
    }
}
