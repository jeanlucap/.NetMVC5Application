using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Empresa.AppMvc.Startup))]
namespace Empresa.AppMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
