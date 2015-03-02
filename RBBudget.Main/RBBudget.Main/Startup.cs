using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RBBudget.Main.Startup))]
namespace RBBudget.Main
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
