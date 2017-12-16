using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NS.Startup))]
namespace NS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
