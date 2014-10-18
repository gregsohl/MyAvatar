using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyAvatar.Startup))]
namespace MyAvatar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
