using Microsoft.EntityFrameworkCore;
using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class RestaurantRepositoryWithDbContext:IRestaurantRepository
    {
       private readonly FormationDbContext _formationDbContext;

        public RestaurantRepositoryWithDbContext(FormationDbContext formationDbContext)
        {
            _formationDbContext = formationDbContext;
        }

        public List<RestaurantModel> GetAll()
        {
           return _formationDbContext.Restaurants.ToList();
        }

        public RestaurantModel GetById(int id)
        {
            return _formationDbContext.Restaurants.Find(id);
        }

        public RestaurantModel Add(RestaurantModel model)
        {
             _formationDbContext.Restaurants.Add(model);
            _formationDbContext.SaveChanges();
            return model;
        }

        public RestaurantModel Delete(RestaurantModel model)
        {
           _formationDbContext?.Restaurants.Remove(model);
            _formationDbContext.SaveChanges();
            return model;
        }

        public RestaurantModel Update(RestaurantModel model)
        {
            //_formationDbContext.Update(model);
            _formationDbContext.Restaurants.Update(model);
            _formationDbContext.SaveChanges();
            return model;
        }

      
    }
}
