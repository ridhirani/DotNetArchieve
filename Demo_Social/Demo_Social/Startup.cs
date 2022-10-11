using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Demo_Social.Startup))]
namespace Demo_Social
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
