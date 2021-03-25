using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyResolvers
            (this IServiceCollection serviceCollection, ICoreModule[] modules)
        {
            foreach (var module in modules)
            {
                module.Load(serviceCollection);
            }

            return ServiceTool.Create(serviceCollection);
        }
    }
}
//Extension classları static olması gerekiyor.
//Apimizin servis bağımlılıklarını yada interceptorları eklediğimiz koleksiyondur.
//Tüm injectionları bir araya toplayabileceğimiz yapı.