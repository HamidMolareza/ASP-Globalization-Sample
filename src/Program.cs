// More Data: https://learn.microsoft.com/en-us/aspnet/core/fundamentals/localization?view=aspnetcore-8.0

using System.Globalization;
using Globalization.Swagger;
using Microsoft.AspNetCore.Localization;
using Swashbuckle.AspNetCore.SwaggerUI;

var supportedCultures = new[] {
    new CultureInfo("en"),
    new CultureInfo("fa"),
};

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
builder.Services.Configure<RequestLocalizationOptions>(options => {
    options.DefaultRequestCulture = new RequestCulture("en");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
});

builder.Services.AddControllers()
    .AddDataAnnotationsLocalization()
    .AddViewLocalization();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => {
    c.OperationFilter<AddHeaderOperationFilter>(); // Register the custom operation filter
});

var app = builder.Build();

app.UseRequestLocalization(new RequestLocalizationOptions {
    ApplyCurrentCultureToResponseHeaders = true,
    DefaultRequestCulture = new RequestCulture("en"),
    SupportedCultures = supportedCultures,
    SupportedUICultures = supportedCultures
});

app.UseSwagger();
app.UseSwaggerUI(c => {
    c.DefaultModelExpandDepth(2);
    c.DefaultModelRendering(ModelRendering.Model);
    c.DefaultModelsExpandDepth(-1);
    c.DisplayOperationId();
    c.DisplayRequestDuration();
    c.DocExpansion(DocExpansion.None);
    c.EnableDeepLinking();
});

app.UseAuthorization();

app.MapControllers();

app.Run();