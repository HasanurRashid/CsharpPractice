using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Queue.Startup))]
namespace Queue
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
