using Microsoft.Owin;
using Owin;
using PetStore.Web.WebApiApplication;

[assembly: OwinStartup(typeof(Startup))]

namespace PetStore.Web.WebApiApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
