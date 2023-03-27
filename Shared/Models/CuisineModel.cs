using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CuisineModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Origine { get; set; }

        //public int RestaurantId { get; set; }
        //public List<RestaurantModel> Restaurant { get; set; }

    }
}
