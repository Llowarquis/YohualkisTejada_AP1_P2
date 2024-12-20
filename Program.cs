using Microsoft.EntityFrameworkCore;
using YohualkisTejada_AP1_P2.Components;
using YohualkisTejada_AP1_P2.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Getting Connection String
var SqlConStr = builder.Configuration.GetConnectionString("SqlConStr");

// Injecting Connection String
builder.Services.AddDbContextFactory<Context>(o => o.UseSqlServer(SqlConStr));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
