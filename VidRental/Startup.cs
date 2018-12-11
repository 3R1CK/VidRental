using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidRental.Startup))]
namespace VidRental
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
