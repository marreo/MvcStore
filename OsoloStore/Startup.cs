using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OsoloStore.Startup))]
namespace OsoloStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
