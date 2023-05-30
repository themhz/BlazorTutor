using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages().AddRazorRuntimeCompilation(); // Enable runtime compilation

var app = builder.Build();

app.UseStaticFiles();

app.MapRazorPages(); // Use Razor Pages routing

app.Run();
