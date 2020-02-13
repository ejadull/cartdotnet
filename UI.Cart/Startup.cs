using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UI.Cart.Startup))]
namespace UI.Cart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
