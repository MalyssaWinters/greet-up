using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(greet_up.Startup))]
namespace greet_up
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
