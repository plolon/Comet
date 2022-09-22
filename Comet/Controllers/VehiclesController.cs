using AutoMapper;
using Comet.DTOs;
using Comet.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Comet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IMapper mapper;

        public VehiclesController(IMapper mapper)
        {
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
        public async Task<IActionResult> CreateVehicle([FromBody] VehicleDto vehicleDto)
        {
            var vehicle = mapper.Map<VehicleDto, Vehicle>(vehicleDto);
            return Ok(vehicle);
        }

        //// PUT api/<VehiclesController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<VehiclesController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
