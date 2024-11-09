using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PPODCOPAS.Startup))]
namespace PPODCOPAS
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
