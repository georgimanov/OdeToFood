using System.Collections.Generic;

using OdeToFood.Entities;

namespace OdeToFood.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>()
            {
                 new Restaurant {Id = 1, Name = "Gosho" } ,
                 new Restaurant {Id = 2, Name = "Pesho" } ,
                 new Restaurant {Id = 3, Name = "Tosho" }
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;
        }
    }
}
