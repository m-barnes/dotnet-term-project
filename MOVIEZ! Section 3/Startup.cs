using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MOVIEZ_.Startup))]
namespace MOVIEZ_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
