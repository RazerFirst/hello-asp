using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP_Simple.Startup))]
namespace ASP_Simple
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
