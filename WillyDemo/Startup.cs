using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WillyDemo.Startup))]
namespace WillyDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
