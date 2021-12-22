using DMR.WebApp.Data;
using DMR.WebApp.Extensions;
using DMR.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

// -------- Configure Middleware Services --------

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ApplicationContext")));

builder.Services.AddDataServices();

// https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.databasedeveloperpageexceptionfilterserviceextensions.adddatabasedeveloperpageexceptionfilter?view=aspnetcore-6.0
builder.Services.AddDatabaseDeveloperPageExceptionFilter();


// -------- Configure Application --------

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
    // https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.builder.migrationsendpointextensions.usemigrationsendpoint?view=aspnetcore-6.0
    app.UseMigrationsEndPoint();
}

// Seed the database when needed
//using (var scope = app.Services.CreateScope())
//{
//    var services = scope.ServiceProvider;
//    try
//    {
//        var context = services.GetRequiredService<ApplicationContext>();
//        DbInitializer.Initialize(context); // Migrate the database
//    }
//    catch (Exception ex)
//    {
//        var logger = services.GetRequiredService<ILogger<Program>>();
//        logger.LogError(ex, "An error occurred initializing the database.");
//    }
//}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
