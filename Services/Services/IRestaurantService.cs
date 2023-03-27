using Models;

namespace Services
{
    public interface IRestaurantService
    {
        public List<RestaurantModel> getAllRestaurants();
        public RestaurantModel getRestaurantById(int id);

        public RestaurantModel addRestaurant(RestaurantModel restaurant);
        public RestaurantModel deleteRestaurant(RestaurantModel restaurant);
        public RestaurantModel updateRestaurant(RestaurantModel restaurant);
    }
}
