using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.IoC
{
    public static class ServiceTool
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public static IServiceCollection Create(IServiceCollection services)    
        {
            ServiceProvider = services.BuildServiceProvider();
            return services;
        }
    }
}

//Autofac vs. oluşturulan injectionları oluşturabilmek için bu class kullanılır.
//.net servislerini al build et bize ver.
