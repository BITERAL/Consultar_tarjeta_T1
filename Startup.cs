using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Consultar_tarjeta_T1.Startup))]
namespace Consultar_tarjeta_T1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
