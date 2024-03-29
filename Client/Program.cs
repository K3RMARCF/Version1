using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PracTest.Client;
using PracTest.Client.Services;
using Toolbelt.Blazor.Extensions.DependencyInjection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("PracTest.ServerAPI", (sp,client) => {
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
    client.EnableIntercept(sp);
})
.AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("PracTest.ServerAPI"));

builder.Services.AddApiAuthorization();
builder.Services.AddHttpClientInterceptor();
builder.Services.AddScoped<HttpInterceptorService>();


await builder.Build().RunAsync();
