using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Accounting.Startup))]
namespace Accounting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
