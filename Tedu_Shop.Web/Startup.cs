using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tedu_Shop.Web.Startup))]
namespace Tedu_Shop.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
