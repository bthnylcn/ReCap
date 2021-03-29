using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.IoC
{
    public interface ICoreModule
    {
        void Load(IServiceCollection serviceCollection);                
    }
}

//.net servislerini yüklememize yarıyor.
//Üst seviyeli sınıflar alt seviyeli sınıfları kullanırken interfaceleri üzerinden kullanır
//üst seviyeli sınıfın ihtiyaç duyduğu nesnenin instance(örneğini)tutuyor.