using Domain.Entities;
using Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrossCutting.ServiceInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenceService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ITaxaJuros, TaxaJuros>();
            serviceCollection.AddTransient<ITaxaJurosService, TaxaJurosService>();
            serviceCollection.AddTransient<ICalculaJurosService, CalculaJurosService>();
        }
    }
}
