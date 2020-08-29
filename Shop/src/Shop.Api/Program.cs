using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Shop.Api
{
#pragma warning disable CS1591
    /// <summary>
    /// Program class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point of the application.
        /// </summary>
        /// <param name="args">Collection of arguments.</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Builds the host to host an application.
        /// </summary>
        /// <param name="args">Collection of arguments.</param>
        /// <returns>Host to host the application.</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
#pragma warning restore CS1591
}
