using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace BlazorWasmConfig
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                                        .AddJsonStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("BlazorWasmConfig.appsettings.json"))
                                        .Build();

            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddTransient(_ => { return configuration.GetSection("GalaxyStuff").Get<GalaxyInfo>(); });

            builder.RootComponents.Add<App>("app");

            await builder.Build().RunAsync();

        }
    }
}
