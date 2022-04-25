using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyV4._1.Startup))]
namespace VidlyV4._1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
