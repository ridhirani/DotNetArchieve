using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Demo_Social_Login1.Startup))]
namespace Demo_Social_Login1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
