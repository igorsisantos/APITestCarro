using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Business.Interfaces;
using API.Business.Notificacoes;
using API.Business.Services;
using API.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace API.Carros.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<IViagemRepository, ViagemRepository>();

            services.AddScoped<IViagemService, ViagemService>();

            services.AddScoped<INotificador, Notificador>();

            return services;
        }
    }
}
