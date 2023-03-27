using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using Models;
using Services;

namespace restaurantAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {
        private readonly IRestaurantService service;

        public RestaurantsController(IRestaurantService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult GetAll() { 

            return Ok(service.getAllRestaurants());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) {
            return Ok(service.getRestaurantById(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody] RestaurantModel restaurant)
        {
            if (restaurant == null)
            {
                return BadRequest();
            }

            service.addRestaurant(restaurant);

            return CreatedAtAction(nameof(GetAll), new { id = restaurant.Id }, restaurant);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] RestaurantModel restaurant)
        {
            if (restaurant == null || restaurant.Id != id)
            {
                return BadRequest();
            }
            if (service.getRestaurantById(id) == null)
            {
                return NotFound();
            }
            service.updateRestaurant(restaurant);
            return new NoContentResult();
        }

        // DELETE api/<CategorieController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(RestaurantModel model,int id)
        {
            var restaurant = service.getRestaurantById(id);
            if (restaurant == null)
            {
                return NotFound();
            }
            service.deleteRestaurant(restaurant);
            return new NoContentResult();

        }


    }
}
