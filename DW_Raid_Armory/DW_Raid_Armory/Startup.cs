using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DW_Raid_Armory.Startup))]
namespace DW_Raid_Armory
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
