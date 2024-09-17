using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OM.QSightApi.Inventory.API.Services;
using OM.QSightApi.Inventory.Core.Interfaces;
using OM.QSightApi.Inventory.Infrastructure.Data;
using OM.QSightApi.Inventory.Infrastructure.Repositories;

namespace OM.QSightApi.Inventory.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            // Add database context
            services.AddDbContext<InventoryDbContext>();

            // Add repository and service dependencies
            services.AddScoped<IInventoryService, InventoryService>();
            services.AddScoped<IZeroOutScheduleService, ZeroOutScheduleService>();
            services.AddScoped<IInventoryRepository, InventoryRepository>();
            services.AddScoped<IZeroOutScheduleRepository, ZeroOutScheduleRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}