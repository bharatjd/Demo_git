using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Demo_Git.Startup))]
namespace Demo_Git
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
