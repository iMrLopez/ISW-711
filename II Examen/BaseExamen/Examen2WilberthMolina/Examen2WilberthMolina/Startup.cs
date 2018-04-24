using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Examen2WilberthMolina.Startup))]
namespace Examen2WilberthMolina
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
