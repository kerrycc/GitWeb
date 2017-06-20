using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitWeb.Startup))]
namespace GitWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
