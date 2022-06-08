using System.Reflection;
using Blazored.LocalStorage;
using GloboTicket.TicketManagement.App;
using GloboTicket.TicketManagement.App.Auth;
using GloboTicket.TicketManagement.App.Contracts;
using GloboTicket.TicketManagement.App.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddBlazoredLocalStorage();

builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();

builder.Services
    .AddScoped<IEventDataService, EventDataService>()
    .AddScoped<ICategoryDataService, CategoryDataService>()
    .AddScoped<IOrderDataService, OrderDataService>()
    .AddScoped<IAuthenticationService, AuthenticationService>();

builder.Services.AddSingleton(new HttpClient
{
    BaseAddress = new Uri(builder.Configuration["apiUrl"] ?? "http://localhost:5000")
});

builder.Services.AddHttpClient<IClient, Client>(client => client.BaseAddress = new Uri(builder.Configuration["apiUrl"] ?? "http://localhost:5000"));

await builder.Build().RunAsync();
