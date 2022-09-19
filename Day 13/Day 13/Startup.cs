using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Day_13.Startup))]
namespace Day_13
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
