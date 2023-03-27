using Models;
using Repositories;

namespace Services
{
    public class RestaurantService : IRestaurantService
    {

        private readonly IRestaurantRepository repository;


        public RestaurantService(IRestaurantRepository repository)
        {
            this.repository = repository;
        }


        public RestaurantModel addRestaurant(RestaurantModel restaurant)
        {
            return repository.Add( restaurant );
        }

        public RestaurantModel deleteRestaurant(RestaurantModel restaurant)
        {
            return repository.Delete( restaurant );
        }

        public List<RestaurantModel> getAllRestaurants()
        {
            return repository.GetAll();
        }

        public RestaurantModel getRestaurantById(int id)
        {
            return repository.GetById( id );
        }

        public RestaurantModel updateRestaurant(RestaurantModel restaurant)
        {
           return repository.Update( restaurant );
        }
    }
}
