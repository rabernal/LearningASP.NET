using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RBBudget.Startup))]
namespace RBBudget
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
