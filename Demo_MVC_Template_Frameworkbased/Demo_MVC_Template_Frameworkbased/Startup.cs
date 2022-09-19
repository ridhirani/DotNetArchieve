using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Demo_MVC_Template_Frameworkbased.Startup))]
namespace Demo_MVC_Template_Frameworkbased
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
