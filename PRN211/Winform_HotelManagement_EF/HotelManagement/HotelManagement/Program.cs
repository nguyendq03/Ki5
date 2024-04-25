using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HotelManagement
{
    public static class Program
    {
        public static IConfiguration Configuration { get; private set; }
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            // Handle adding the configuration
            var builder = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();

            // Handle adding the services
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            serviceCollection.AddBussinessDatabase(Configuration);

            // Handle adding the service provider
            ApplicationConfiguration.Initialize();
            ServiceProvider = serviceCollection.BuildServiceProvider();
            var mainWindow = ServiceProvider.GetRequiredService<frm_Report>();
            Application.Run(mainWindow);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<frm_Report>();
            services.AddTransient<frm_Customer>();
            services.AddTransient<frm_Room>();
            services.AddTransient<frm_Booking>();
        }

        private static IServiceCollection AddBussinessDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("LocalDB");
            services.AddDbContext<HotelManagementSystemContext>(o =>
            {
                o.UseSqlServer(connectionString);
            });
            return services;
        }
    }
}