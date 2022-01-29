using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace sistema_escolar.API.Controllers
{
    [Route("api/notas")]
    [ApiController]
    public class NotaController : ControllerBase
    {
        // GET: api/<NotaController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<NotaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<NotaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<NotaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<NotaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
