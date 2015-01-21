using Microsoft.Owin;
using Owin;
using PetStore.Web.MvcWebApplication;

[assembly: OwinStartup(typeof(Startup))]
namespace PetStore.Web.MvcWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
