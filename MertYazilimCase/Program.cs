using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using MertYazilimCase.Data.DataLayer;

namespace MertYazilimCase
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var builder = new HostBuilder().ConfigureServices((hostContext, services) =>
            {
                services.AddScoped<FormMain>();
                services.AddDbContext<DatabaseContext>(options =>
                options.UseSqlServer(@"Server=localhost;Initial Catalog=MertYazilimCase;Trusted_Connection=True;"));

                var serilogLogger = new LoggerConfiguration()
                .WriteTo.File("../../../../logs.txt")
                .CreateLogger();
                services.AddLogging(x =>
                {
                    x.SetMinimumLevel(LogLevel.Information);
                    x.AddSerilog(logger: serilogLogger, dispose: true);
                });

            });

            var host = builder.Build();
            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {

                    var context = services.GetRequiredService<DatabaseContext>();
                    context.Database.Migrate();
                    var formMain = services.GetRequiredService<FormMain>();
                    Application.Run(formMain);

                    Console.WriteLine("Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Console.WriteLine("Error Occured");
                }
            }
        }
    }
}