using Edu.Application.Implementations;
using Edu.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Edu.Application.Extension
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IApplicationRepository, ApplicationRepository>();
            return services;
        }
    }
}
