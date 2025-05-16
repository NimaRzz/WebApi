using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Project.Infra.Data;
using Project.Infra.Data.Contexts;
using Project.Infra.IoC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DataBaseContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DataBaseContext"))
);

builder.Services.Configure<CookieAuthenticationOptions>(IdentityConstants.ApplicationScheme, options =>
{
    options.ExpireTimeSpan = TimeSpan.FromDays(7);
});

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("Admin", policy => policy.RequireRole("Admin"));
    options.AddPolicy("Operator", policy => policy.RequireRole("Operator"));
    options.AddPolicy("AdminOrOperator", policy => policy.RequireAssertion(context => context.User.IsInRole("Admin") || context.User.IsInRole("Operator")));
});

builder.Services.AddAuthentication();

builder.Services.AddIdentity<User, Role>(c =>

  c.User.RequireUniqueEmail = true


).AddEntityFrameworkStores<DataBaseContext>();

builder.Services.AddRazorPages();

builder.Services.AddMvc();

RegisterServices(builder.Services);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapDefaultControllerRoute();

app.MapControllers();

app.MapRazorPages();


app.Run();


//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllerRoute(
//          name: "areas",
//          pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
//    );
//});


static void RegisterServices(IServiceCollection services)
{
    DependencyContainer.RegisterServices(services);
}