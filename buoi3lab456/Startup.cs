using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(buoi3lab456.Startup))]
namespace buoi3lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
