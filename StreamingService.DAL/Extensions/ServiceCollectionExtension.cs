using Microsoft.Extensions.DependencyInjection;
using StreamingService.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace StreamingService.DAL.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void InjectDatabaseServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDatabase(configuration);
        }

        private static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            // add database, use sql server
            services.AddDbContext<StreamingDbContext>(options =>
            {
                options.UseSqlServer(configuration["ConnectionString"]);
            });

        }
    }
}
