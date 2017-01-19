using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UniversityWebApplication.Startup))]
namespace UniversityWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
