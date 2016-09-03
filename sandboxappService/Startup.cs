using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(sandboxappService.Startup))]

namespace sandboxappService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}