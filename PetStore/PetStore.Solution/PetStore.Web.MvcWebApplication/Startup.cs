using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PetStore.Web.MvcWebApplication.Startup))]
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
