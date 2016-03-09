using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoalLineStandPrototype.Startup))]
namespace GoalLineStandPrototype
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
