using Microsoft.AspNetCore.Mvc;

namespace Comet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MakesController : ControllerBase
    {
        // GET: api/<MakesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MakesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MakesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MakesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MakesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
