using mitoSoft.Razor.Components;
using mitoSoft.Razor.Components.Examples.DotNet6.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<ErrorBoundaryOptions>(new ErrorBoundaryOptions()
{
    Mode = ErrorBoundaryMode.ErrorText,
    Reload = true,
    ShowChildContentOnError = false,
    RedirectUri = "#",
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
