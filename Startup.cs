using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BaldwinMIS4200.Startup))]
namespace BaldwinMIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
