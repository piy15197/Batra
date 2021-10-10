using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Batra.Startup))]
namespace Batra
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
