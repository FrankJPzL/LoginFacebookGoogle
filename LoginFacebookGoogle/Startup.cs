using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoginFacebookGoogle.Startup))]
namespace LoginFacebookGoogle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
