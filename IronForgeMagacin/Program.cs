using IronForge.Plugins.InMemory;
using IronForge.UseCases.Inventories;
using IronForge.UseCases.Inventories.Interfaces;
using IronForge.UseCases.PluginInterfaces;
using IronForgeMagacin.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents();

builder.Services.AddSingleton<IInventoryRepository, InventoryRepository>();

builder.Services.AddTransient<IViewInventoriesByNameUseCase, ViewInventoriesByNameUseCase>();

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

app.MapRazorComponents<App>();

app.Run();
