using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DOAN_WEBBANHANG.Startup))]
namespace DOAN_WEBBANHANG
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
