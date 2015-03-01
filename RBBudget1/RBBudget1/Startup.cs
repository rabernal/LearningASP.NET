using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RBBudget1.Startup))]
namespace RBBudget1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
