using Microsoft.EntityFrameworkCore;
using Models;
using System.Linq.Expressions;

namespace Repositories
{
    public interface IRestaurantRepository
    {
       // List<RestaurantModel> restaurantModel { get; set; }

        List<RestaurantModel> GetAll();

        RestaurantModel GetById(int Id);
        RestaurantModel Add(RestaurantModel model);
        RestaurantModel Delete(RestaurantModel model);

        RestaurantModel Update(RestaurantModel model);

    }
}
