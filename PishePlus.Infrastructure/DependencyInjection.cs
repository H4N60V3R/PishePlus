using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PishePlus.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace PishePlus.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PishePlusContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("Local"),
                    b => b.MigrationsAssembly(typeof(PishePlusContext).Assembly.FullName)));

            //services.AddScoped<IPishePlusContext>(provider => provider.GetService<PishePlusContext>());

            return services;
        }
    }
}
