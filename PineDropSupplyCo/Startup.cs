using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PineDropSupplyCo.Startup))]
namespace PineDropSupplyCo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
