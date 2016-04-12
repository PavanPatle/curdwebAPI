using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRUDwithWebAPIandAngular.Startup))]
namespace CRUDwithWebAPIandAngular
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
