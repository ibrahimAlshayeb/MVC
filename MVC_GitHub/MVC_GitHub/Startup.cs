using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_GitHub.Startup))]
namespace MVC_GitHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
