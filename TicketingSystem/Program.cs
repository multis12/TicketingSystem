using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TicketingSystem.Extensions;
using TicketingSystem.Infrastructure.Data;


var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<AppUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = builder.Configuration.GetValue<bool>("Account:RequireConfirmedAccount");
    options.SignIn.RequireConfirmedEmail = builder.Configuration.GetValue<bool>("Account:RequireConfirmedEmail");
    options.SignIn.RequireConfirmedPhoneNumber = builder.Configuration.GetValue<bool>("Account:RequireConfirmedPhoneNumber");
    options.Password.RequiredLength = builder.Configuration.GetValue<int>("Account:RequiredLength");
    options.Password.RequireNonAlphanumeric = builder.Configuration.GetValue<bool>("Account:RequireNonAlphanumeric");
    options.Password.RequireDigit = builder.Configuration.GetValue<bool>("Account:RequireDigit");
})
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

builder.Services.AddApplicationServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );

    endpoints.MapRazorPages();
});

app.Run();
