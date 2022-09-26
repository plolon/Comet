using AutoMapper;
using Comet.DTOs;
using Comet.Persistence.IRepositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Comet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly IFeatureRepository featureRepository;
        private readonly IMapper mapper;

        public FeaturesController(IFeatureRepository featureRepository, IMapper mapper)
        {
            this.featureRepository = featureRepository;
            this.mapper = mapper;
        }
        // GET: api/<FeatureController>
        [HttpGet]
        public async Task<IEnumerable<KeyValuePairDto>> Get()
        {
            var features = await featureRepository.GetAll();
            return mapper.Map<IEnumerable<KeyValuePairDto>>(features);
        }

        // GET api/<FeatureController>/5
        [HttpGet("{id}")]
        public async Task<KeyValuePairDto> Get(int id)
        {
            var feature = await featureRepository.Get(id);
            return mapper.Map<KeyValuePairDto>(feature);
        }

        // POST api/<FeatureController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<FeatureController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<FeatureController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
