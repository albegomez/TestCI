using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestCI.Startup))]
namespace TestCI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
