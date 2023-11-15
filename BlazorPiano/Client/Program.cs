global using BlazorPiano.Shared;
global using System.Net.Http.Json;
global using BlazorPiano.Client.Services.ProductServices;
global using BlazorPiano.Client;
global using BlazorPiano.Client.Services.DetailsServices;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IDetailsServices, DetailsServices>();
await builder.Build().RunAsync();
