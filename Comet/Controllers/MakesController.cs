using Comet.Persistence.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Comet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MakesController : ControllerBase
    {
        private readonly IMakeRepository makeRepository;

        public MakesController(IMakeRepository makeRepository)
        {
            this.makeRepository = makeRepository;
        }
        // GET: api/<MakesController>
        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            var makes = await makeRepository.GetAllMakesWithModels();
            return null; 
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
