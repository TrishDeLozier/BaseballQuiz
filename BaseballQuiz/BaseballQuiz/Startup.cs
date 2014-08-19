using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BaseballQuiz.Startup))]
namespace BaseballQuiz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
