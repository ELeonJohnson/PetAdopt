using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PetAdopt.Startup))]
namespace PetAdopt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
