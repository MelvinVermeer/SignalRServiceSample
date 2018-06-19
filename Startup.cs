using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace SampleSignalRService
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSignalR()
                    .AddAzureSignalR(options => 
                    {
                        options.ConnectionString = "Endpoint=<yourconnectionstring>";
                    });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseFileServer();
            app.UseAzureSignalR(routes => {
                routes.MapHub<ChatHub>("/chat");
            });
        }
    }
}
