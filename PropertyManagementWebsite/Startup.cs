using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PropertyManagementWebsite.Startup))]
namespace PropertyManagementWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
