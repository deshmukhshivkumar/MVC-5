using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc5AppV2.Startup))]
namespace Mvc5AppV2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
