using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LabTeste_MVC_API.Startup))]
namespace LabTeste_MVC_API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
