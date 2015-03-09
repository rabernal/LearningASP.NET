using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeBudget.Web.Startup))]
namespace HomeBudget.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
