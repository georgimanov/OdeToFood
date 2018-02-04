namespace OdeToFood.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Restaurant
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        public string Name { get; set; }

        [Required]
        public CuisineType Cuisine { get; set; }
    }
}
