using Microsoft.Extensions.DependencyInjection;
using Repositories;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class ServiceExtension
    {
        public static void AddServices(this IServiceCollection service, string connectionString)
        {
            //service.AddSingleton<IRestaurantService, RestaurantService>();
            service.AddScoped<IRestaurantService, RestaurantService>();
            service.AddScoped<ICuisineService, CuisineService>();
            service.AddRepositories(connectionString);
        }
    }
}
