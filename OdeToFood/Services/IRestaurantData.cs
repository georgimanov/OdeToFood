﻿namespace OdeToFood.Services
{
    using System.Collections.Generic;

    using OdeToFood.Models;

    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();

        Restaurant Get(int id);

        Restaurant Add(Restaurant restaurant);

        Restaurant Update(Restaurant restaurant);
    }
}
