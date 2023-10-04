using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QueueExampleDemo.Startup))]
namespace QueueExampleDemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
