using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC.HelloWorld.Startup))]
namespace MVC.HelloWorld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
