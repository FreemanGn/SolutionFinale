using Microsoft.AspNetCore.Mvc;
using Models;
using Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace restaurantAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CuisineController : ControllerBase
    {
        private readonly ICuisineService service;


        public CuisineController(ICuisineService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {

            return Ok(service.getAllCuisines());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(service.getCuisineById(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody] CuisineModel cuisine)
        {
            if (cuisine == null)
            {
                return BadRequest();
            }

            service.addCuisine(cuisine);
            Console.WriteLine(cuisine);

            return CreatedAtAction(nameof(GetAll), new { id = cuisine.Id }, cuisine);
        }

        [HttpPut]
        public IActionResult Update([FromBody] CuisineModel cuisine)
        {
            //if (cuisine == null || cuisine.Id != id)
            //{
            //    return BadRequest();
            //}
            //if (service.getCuisineById(id) == null)
            //{
            //    return NotFound();
            //}
            service.updateCuisine(cuisine);
            return new NoContentResult();
        }

        // DELETE api/<CategorieController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var cuisine = service.getCuisineById(id);
            if (cuisine == null)
            {
                return NotFound();
            }
            service.deleteCuisine(cuisine);
            return new NoContentResult();

        }


    }
}
