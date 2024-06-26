using BookingHolidayReservations.Core.Contracts;
using BookingHolidayReservations.Core.Services;
using BookingHolidayReservations.Infrastructure.Data.Common;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddApplicationDbContext(builder.Configuration);
builder.Services.AddApplicationIdentity(builder.Configuration);
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddScoped<IHolidaysService, HolidaysService>();

builder.Services.AddControllersWithViews();
builder.Services.AddControllersWithViews();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapDefaultControllerRoute();
app.MapRazorPages();

await app.RunAsync();
