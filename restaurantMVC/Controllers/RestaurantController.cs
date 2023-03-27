using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Repositories;
using  Services;
using System.ComponentModel.Design;
using System.Reflection;

namespace Controllers
{
    public class RestaurantController : Controller
    {
        private readonly IRestaurantService service;

        public RestaurantController(IRestaurantService service)
        {
            this.service = service;
        }



        // GET: RestaurantController
        public ActionResult Index()
        {
            var model = service.getAllRestaurants();
            return View(model);
        }

        // GET: RestaurantController/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var model = service.getRestaurantById(id);
            if (model == null)
            {
                return NotFound();
            }


            return View(model);
        }

        // GET: RestaurantController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RestaurantController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RestaurantModel restaurant)
        {
            if (ModelState.IsValid)
            {
                service.addRestaurant(restaurant);
                //Console.WriteLine(restaurant.Name);
                
                return RedirectToAction(nameof(Index));
            }
            return View(restaurant);
        }

        // GET: RestaurantController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = service.getRestaurantById(id);
            return View(model);

        }

        // POST: RestaurantController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(RestaurantModel restaurant)
        {
            var model = service.updateRestaurant(restaurant);
            if (model == null)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: RestaurantController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = service.getRestaurantById(id);
            return View(model);
        }

        // POST: RestaurantController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete( RestaurantModel restaurant)
        {
            var model = service.deleteRestaurant(restaurant);
            if (model == null)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Index));
          
        }
    }
}
