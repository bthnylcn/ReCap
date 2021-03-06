using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {                                                                                   //Servis bağımlılıklarımızı çözümlediğimiz yer.
            serviceCollection.AddMemoryCache();                                             //Ortak katmanı ilgilendirir sadece
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();    //Singleton 1 kere yapılıp herkes onu kullanır
            serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>();
            serviceCollection.AddSingleton<Stopwatch>();
        }
    }
}
