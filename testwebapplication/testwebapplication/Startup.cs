using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testwebapplication.Startup))]
namespace testwebapplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
