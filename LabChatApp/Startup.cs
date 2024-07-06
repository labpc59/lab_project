// Startup.cs
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;

  using Microsoft.AspNetCore.Internal;
using Microsoft.Extensions.DependencyInjection;

namespace LabChatApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSignalR();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); // Ensure this method is recognized
            }

            app.UseRouting(); // Ensure this method is recognized

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<ChatHub>("/chathub");
            });
        }
    }
}
