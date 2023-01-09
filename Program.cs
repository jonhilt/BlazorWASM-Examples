using System;
using System.Net.Http;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using BlazorExamples.WASM.FakeBackend;
using BlazorExamples.WASM.Pages.PurchaseOrderDashboard.Models;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;


namespace BlazorExamples.WASM
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(
                sp => new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)});
            
            builder.Services.AddBlazoredLocalStorage();

            builder.Services.AddSingleton<FakeApi>();
            builder.Services.AddSingleton<FakeDB>();
            
            await builder.Build().RunAsync();
        }
    }
}