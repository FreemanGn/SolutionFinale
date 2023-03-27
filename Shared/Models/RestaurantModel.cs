using Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class RestaurantModel
    {
        public int Id { get; set; }

        
        public string Name { get; set; }

        
        public string Description { get; set; }

       
        public string Addresse { get; set; }

        [ForeignKey("Cuisine")]
        public int CuisineId { get; set; }
        public  CuisineModel Cuisine { get; set;}


    }
}
