using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ClientSideBlazorDemoV2
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddSingleton<WeatherForecastService>();
            services.AddSingleton<OffenseService>();
            services.AddSingleton<BingMapService>();
            services.AddSingleton<RegistrationService>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
