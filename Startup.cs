using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fundraising.Startup))]
namespace Fundraising
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
