using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public static class RepositoryExtention
    {
        public static void AddRepositories(this IServiceCollection service, string connectionString)
        {
            //service.AddSingleton<IRestaurantRepository, RestaurantRepository>();
            service.AddScoped<IRestaurantRepository, RestaurantRepositoryWithDbContext>();
            service.AddScoped<ICuisineRepository, CuisineRepository>();
            service.AddDbContext<FormationDbContext>(x => x.UseSqlServer(connectionString));
        }
    }
}
