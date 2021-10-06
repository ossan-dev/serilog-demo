using Microsoft.Azure.Functions.Worker.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using System.IO;
using System.Threading.Tasks;

namespace serilog_demo_func
{
    public class Program
    {
        public static void Main()
        {
            var host = new HostBuilder()                
                .ConfigureFunctionsWorkerDefaults()
                .ConfigureAppConfiguration(options => options.AddJsonFile(Path.Combine(@"C:\Projects\SampleProjects\serilog-demo\serilog-demo\serilog-demo-app\serilog-demo-func", "appsettings.json"), optional: false, reloadOnChange: true))
                .UseSerilog((context, logger) => logger.ReadFrom.Configuration(context.Configuration))
                .Build();

            host.Run();
        }
    }
}