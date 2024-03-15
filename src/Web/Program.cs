using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Identity;
using DNMOFT.CostTrackr.DataAccess.Entities.Identity;
using DNMOFT.CostTrackr.Web.Helpers;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("sidebar.json", optional: true, reloadOnChange: true);

// This line of code should be removed when deployed to production
builder.Configuration.AddJsonFile("connectionstrings.json", optional: true, reloadOnChange: true);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
   {
       options.UseNpgsql(connectionString,
                         x =>
                         {
                             x.MigrationsAssembly("DNMOFT.CostTrackr.DataAccess");
                             x.MigrationsHistoryTable("mEFMH");
                             x.UseNetTopologySuite();
                         })
            .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTrackingWithIdentityResolution)
            .ReplaceService<IHistoryRepository, CustomHistory>();
   });

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentity<mUser, mRole>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultUI()
    .AddDefaultTokenProviders();


builder.Services.AddRazorPages();
builder.Services.AddControllers();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "CostTrackR API", Version = "v1" });
});

builder.Services.AddStackExchangeRedisCache(options =>  
{  
    options.Configuration = builder.Configuration.GetConnectionString("Redis");
    options.InstanceName = "costtrackr_"; 
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

using(var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<ApplicationDbContext>();
    var userManager = services.GetRequiredService<UserManager<mUser>>();
    var roleManager = services.GetRequiredService<RoleManager<mRole>>();
    var logger = services.GetRequiredService<ILogger<Program>>();
    var configuration = services.GetRequiredService<IConfiguration>();

    try
    {
        context.Database.EnsureCreated();
        SeedData.Initialize(context).Wait();
    }
    catch (Exception ex)
    {
        logger.LogError(ex, "An error occurred while migrating or seeding the database.");
    }
}

app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CostTrackR API"));

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();

app.MapControllerRoute(
    name: "default",
    pattern: "api/{controller}/{action}/{id?}"
);

app.Run();
