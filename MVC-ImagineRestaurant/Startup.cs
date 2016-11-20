using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_ImagineRestaurant.Startup))]
namespace MVC_ImagineRestaurant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
