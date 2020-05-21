using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebLabParking.BLL.Abstract;
using WebLabParking.BLL.Impl;
using WebLabParking.DAL.Abstract;
using WebLabParking.DAL.Impl;

namespace WebLabParking.Web
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
            services.AddControllersWithViews();
            services.AddTransient<ICarRepository, CarRepository>();
            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddTransient<IParkingRepository, ParkingRepository>();
            services.AddTransient<IParkingPlaceRepository, ParkingPlaceRepository>();
            services.AddTransient<IParkingTicketRepository, ParkingTicketRepository>();
            services.AddTransient<ICarService, CarService>();
            services.AddTransient<IClientService, ClientService>();
            services.AddTransient<IParkingService, ParkingService>();
            services.AddTransient<IParkingTicketService, ParkingTicketService>();
            services.AddTransient<IParkingPlaceService, ParkingPlaceService>();
        }
        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=GetParkings}/{id?}");
            });
        }
    }
}
