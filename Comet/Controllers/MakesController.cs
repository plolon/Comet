using AutoMapper;
using Comet.DTOs;
using Comet.Persistence.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Comet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MakesController : ControllerBase
    {
        private readonly IMakeRepository makeRepository;
        private readonly IMapper mapper;

        public MakesController(IMakeRepository makeRepository, IMapper mapper)
        {
            this.makeRepository = makeRepository;
            this.mapper = mapper;
        }
        // GET: api/<MakesController>
        [HttpGet]
        public async Task<IEnumerable<MakeDto>> Get()
        {
            var makes = await makeRepository.GetAllMakesWithModels();
            return mapper.Map<IEnumerable<MakeDto>>(makes);
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
