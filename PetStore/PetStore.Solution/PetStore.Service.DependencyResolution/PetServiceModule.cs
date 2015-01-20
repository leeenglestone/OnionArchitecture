using Ninject.Modules;
using PetStore.Domain.Interfaces;
using PetStore.Domain.Repository;
using PetStore.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Service.DependencyResolution
{
    public class PetServiceModule : NinjectModule
    {
        public override void Load()
        {
            // Bind services
            Bind<IPetService>().To<PetService>();
            //var configService = Kernel.Get<IConfigService>();

            // Bind repositories         
            Bind<IPetRepository>().To<PetRepository>();//.WithConstructorArgument("connectionString", configService.NorthwindConnection);
        }
    }
}
