using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5Final.Startup))]
namespace MVC5Final
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
