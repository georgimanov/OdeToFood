namespace OdeToFood.Services
{
    using System.Collections.Generic;
    using System.Linq;

    using OdeToFood.Models;

    public class InMemoryRestaurantData : IRestaurantData
    {
        private readonly List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant {Id = 1, Name = "GM's"},
                new Restaurant {Id = 2, Name = "Pizza"},
                new Restaurant {Id = 3, Name = "Burgers"},
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Name);
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(r => r.Id == id);
        }
    }
}
