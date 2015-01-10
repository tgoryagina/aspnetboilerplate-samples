using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleTaskSystem.WebSpaAngular.Startup))]
namespace SimpleTaskSystem.WebSpaAngular
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}