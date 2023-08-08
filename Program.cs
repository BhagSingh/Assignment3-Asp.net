using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Assignment3_Asp.net.Data;
namespace Assignment3_Asp.net
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<Assignment3_AspnetContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("Assignment3_AspnetContext") ?? throw new InvalidOperationException("Connection string 'Assignment3_AspnetContext' not found.")));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
               /* pattern: "{controller=Home}/{action=Index}/{id?}");*/
        pattern: "{controller=Movies}/{action=Index}/{id?}");

            app.Run();
        }
    }
}