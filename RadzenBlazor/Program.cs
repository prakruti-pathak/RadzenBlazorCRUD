using Microsoft.EntityFrameworkCore;
using Radzen;
using RadzenBlazor.Components;
using RadzenBlazor.Domains;
using RadzenBlazor.Infrastructure;
using RadzenBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<ICarRepository, CarRepository>();
builder.Services.AddScoped<ICarService, CarService>();
builder.Services.AddRadzenComponents();
builder.Services.AddScoped<DialogService>();

builder.Services.AddDbContextPool<CarDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("mydb"));
});

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
