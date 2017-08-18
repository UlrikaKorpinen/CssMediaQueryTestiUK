using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CssMediaQueryTestiUK.Startup))]
namespace CssMediaQueryTestiUK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
