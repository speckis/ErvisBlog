using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ErvisBlog.Startup))]
namespace ErvisBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
