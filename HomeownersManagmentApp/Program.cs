using HomeownersManagmentApp.Components;
using HomeownersManagmentApp.Interfaces;
using HomeownersManagmentApp.Services;
using Syncfusion.Blazor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddSyncfusionBlazor();
builder.Services.AddSingleton<IViewService, ViewService>();
builder.Services.AddTelerikBlazor();

var app = builder.Build();

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense
    (
    "Ngo9BigBOggjHTQxAR8/V1NNaF1cWWhOYVJzWmFZfVtgc19GaFZURGYuP1ZhSXxWdkNiXH9ZcHxQQmhVWEZ9XUs="
    );

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
