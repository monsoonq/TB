using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TB.Startup))]
namespace TB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
