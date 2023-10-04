using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QueueDemo.Startup))]
namespace QueueDemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
