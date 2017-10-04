using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PotLuck.Startup))]
namespace PotLuck
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
