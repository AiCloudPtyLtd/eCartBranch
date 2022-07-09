using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eCart.Startup))]
namespace eCart
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
