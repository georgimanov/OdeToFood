namespace OdeToFood.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    using OdeToFood.Models;

    public class RestaurantEditModel
    {
        [Required, MaxLength(80)]
        public string Name { get; set; }

        [Required]
        public CuisineType Cuisine { get; set; }
    }
}
