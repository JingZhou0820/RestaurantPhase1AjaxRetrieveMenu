using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestaurantPhase1beforeAjax1.Startup))]
namespace RestaurantPhase1beforeAjax1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
