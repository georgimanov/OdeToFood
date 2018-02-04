namespace OdeToFood.ViewModels
{
    using System.Collections.Generic;

    using OdeToFood.Models;

    public class HomeIndexViewModel
    {
        public string CurrentMessage { get; set; }

        public IEnumerable<Restaurant> Restaurants { get; set; }
    }
}
