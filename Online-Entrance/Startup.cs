using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Online_Entrance.Startup))]
namespace Online_Entrance
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
