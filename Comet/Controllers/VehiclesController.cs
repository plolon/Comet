using AutoMapper;
using Comet.DTOs.Vehicle;
using Comet.Models;
using Comet.Persistence.IRepositories;
using Comet.Persistence.Repositories;
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
        // GET: api/<VehiclesController>
        [HttpGet]
        public async Task<IEnumerable<VehicleDto>> Get()
        {
            var vehicles = await vehicleRepository.GetAllVehiclesWithFeatures();
            return mapper.Map<IEnumerable<VehicleDto>>(vehicles);
        }

        // GET api/<VehiclesController>/5
        [HttpGet("{id}")]
        public async Task<VehicleDto> Get(int id)
        {
            var vehicle = await vehicleRepository.GetVehicleWithFeatures(id);
            return mapper.Map<VehicleDto>(vehicle);
        }

        // POST api/<VehiclesController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] SaveVehicleDto vehicleDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var vehicle = mapper.Map<Vehicle>(vehicleDto);
            var result = await vehicleRepository.Add(vehicle);
            var response = mapper.Map<VehicleDto>(result);
            return Ok(response);
        }

        // PUT api/<VehiclesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] SaveVehicleDto vehicleDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var vehicle = await vehicleRepository.Get(id);
            mapper.Map(vehicleDto, vehicle);
            var result = await vehicleRepository.Update(vehicle);
            var response = mapper.Map<VehicleDto>(result);
            return Ok(response);
        }

        // DELETE api/<VehiclesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await vehicleRepository.Delete(id);
            return Ok(result);
        }
    }
}
