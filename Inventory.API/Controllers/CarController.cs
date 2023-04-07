using Inventory.API.Models;
using Inventory.API.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Inventory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;
        public CarController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_carService.GetCars());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
           
            return Ok(_carService.GetCarById(id));
        }
        [HttpPost]
        public IActionResult Post([FromBody] Car car)
        {
            _carService.SaveCar(car);
            return CreatedAtAction(nameof(Get), car.Id); 
        }

        [HttpPut]
        public IActionResult PutCar(int carId,[FromBody] Car car)
        {
            _carService.UpdateCar(carId, car);
            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeleteCar(int carId)
        {
            _carService.DeleteCar(carId);
            return NoContent();
        }

    }
}
