﻿namespace OdeToFood.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using OdeToFood.Models;
    using OdeToFood.Services;
    using OdeToFood.ViewModels;

    public class HomeController : Controller
    {
        private readonly IRestaurantData _restaurantData;
        private readonly IGreeter _greeter;

        public HomeController(IRestaurantData restaurantData, IGreeter greeter)
        {
            _restaurantData = restaurantData;
            _greeter = greeter;
        }

        public IActionResult Index()
        {
            var model = new HomeIndexViewModel
            {
                Restaurants = _restaurantData.GetAll(),
                CurrentMessage = _greeter.GetGreeting()
            };

            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = _restaurantData.Get(id);
            if (model == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RestaurantEditModel model)
        {
            var restaurant = new Restaurant
            {
                Name = model.Name,
                Cuisine = model.Cuisine
            };

            restaurant = _restaurantData.Add(restaurant);

            return View(nameof(Details), restaurant);
        }
    }
}
