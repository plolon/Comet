using AutoMapper;
using Comet.DTOs;
using Comet.Models;
using Comet.Persistence.IRepositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Comet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IVehicleRepository vehicleRepository;
        private readonly IMapper mapper;

        public VehiclesController(IVehicleRepository vehicleRepository, IMapper mapper)
        {
            this.vehicleRepository = vehicleRepository;
            this.mapper = mapper;
        }
        //// GET: api/<VehiclesController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<VehiclesController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<VehiclesController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] VehicleDto vehicleDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var vehicle = mapper.Map<Vehicle>(vehicleDto);
            await vehicleRepository.Add(vehicle);
            var response = mapper.Map<VehicleDto>(vehicle);
            return Ok(response);
        }

        // PUT api/<VehiclesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] VehicleDto vehicleDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var vehicle = await vehicleRepository.Get(id);
            mapper.Map(vehicleDto, vehicle);
            await vehicleRepository.Update(vehicle);

            var response = mapper.Map<VehicleDto>(vehicle);
            return Ok(response);
        }

        //// DELETE api/<VehiclesController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
