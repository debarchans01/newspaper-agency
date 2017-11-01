using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITLabProject.Startup))]
namespace ITLabProject
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
