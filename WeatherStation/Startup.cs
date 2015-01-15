using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WeatherStation.Startup))]
namespace WeatherStation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
