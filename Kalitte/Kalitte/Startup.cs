using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kalitte.Startup))]
namespace Kalitte
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
