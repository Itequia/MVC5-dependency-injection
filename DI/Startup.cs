using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DI.Startup))]
namespace DI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
