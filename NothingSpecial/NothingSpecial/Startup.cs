using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NothingSpecial.Startup))]
namespace NothingSpecial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
