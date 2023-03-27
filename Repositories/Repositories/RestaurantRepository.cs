using Microsoft.EntityFrameworkCore;
using Models;
using System.Linq.Expressions;

namespace Repositories
{
    public class RestaurantRepository : IRestaurantRepository
    {
        public List<RestaurantModel> restaurantModel { get ; set ; }


        public RestaurantRepository()
        {
            restaurantModel = new List<RestaurantModel>()
            {
                new RestaurantModel()
                {
                    Id = 1,
                    Name = "Burger King",
                    Description ="Restaurant spécialisé dans les burger",
                    Addresse ="9 Rue Oued Sebou"

                },
                 new RestaurantModel()
                {
                    Id = 2,
                    Name = "Pizza Hut",
                    Description ="Restaurant spécialisé dans les pizzas",
                    Addresse ="22 Rue Ibn Sina"
                },
                new RestaurantModel()
                {
                    Id = 3,
                    Name = "KFC",
                    Description ="Restaurant spécialisé dans le poulet frit",
                    Addresse ="13 Rue Ibn Batouta"
                },
                new RestaurantModel()
                {
                    Id = 4,
                    Name = "McDonald's",
                    Description ="Restaurant de fast-food",
                    Addresse ="4 Rue Ibn Khaldoun"
                },
                new RestaurantModel()
                {
                    Id = 5,
                    Name = "Subway",
                    Description ="Restaurant de sandwichs et salades",
                    Addresse ="7 Rue Abou Bakr El Kadiri"
                },
            };

        }

        public List<RestaurantModel> GetAll()
        {
            return restaurantModel;
        }

        public RestaurantModel Add(RestaurantModel model)
        {
            restaurantModel.Add(model);
            return model; 
        }
        public RestaurantModel Delete(RestaurantModel model)
        {
            var idRecuperer = GetById(model.Id);
           restaurantModel.Remove(idRecuperer);
            return model;
        }

       

        public RestaurantModel GetById(int Id)
        {
            return restaurantModel.SingleOrDefault(x => x.Id == Id);
        }

        public RestaurantModel Update(RestaurantModel model)
        {
            var ModelRecuperer = GetById(model.Id);

            if (ModelRecuperer == null)
            {
                throw new ArgumentException("RestaurantModel not found");
                // or return null;
            }

            ModelRecuperer.Name = model.Name;
            ModelRecuperer.Description = model.Description;
            ModelRecuperer.Addresse = model.Addresse;

            return ModelRecuperer;



        }

    }
}
