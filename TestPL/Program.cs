using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using TestBUS.Mapper;
using TestBUS.Service.Implement;
using TestBUS.Service.Interface;
using TestDAL.Repo.Implement;
using TestDAL.Repo.Interface;
using TestPL;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddMudServices();
builder.Services.AddScoped<IApiService, ApiService>();
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://localhost:7163")
});

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
