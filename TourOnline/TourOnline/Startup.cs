using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TourOnline.Startup))]
namespace TourOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
