using ASH.Application.Interfaces;
using ASH.Application.Service;
using ASH.Infrastructure.Interfaces;
using ASH.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASH.API.DependancyInjection
{
    public static class StartupExtensions
    {
        public static IServiceCollection DIExtension(this IServiceCollection services)
        {
            services.AddTransient<IWorkerService, WorkerService>();
            services.AddTransient<IWorkerRepository, WorkerRepositry>();

            return services;
        }
    }
}
