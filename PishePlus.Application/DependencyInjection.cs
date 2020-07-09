using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using PishePlus.Application.Common.Behaviors;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace PishePlus.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            //services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
