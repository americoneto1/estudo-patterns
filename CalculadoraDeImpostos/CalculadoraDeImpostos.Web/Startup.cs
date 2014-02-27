using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CalculadoraDeImpostos.Web.Startup))]
namespace CalculadoraDeImpostos.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
