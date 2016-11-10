using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectLesson9.Startup))]
namespace ProjectLesson9
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
