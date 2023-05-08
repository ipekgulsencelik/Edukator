using Edukator.BussinessLayer.Abstract;
using Edukator.BussinessLayer.Concrete;
using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Concrete;
using Edukator.DataAccessLayer.EntityFramework;
using Edukator.EntityLayer.Concrete;

namespace Edukator.PresentationLayer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<Context>();

            builder.Services.AddScoped<ICategoryDAL, EFCategoryDAL>();
            builder.Services.AddScoped<ICategoryService, CategoryManager>();

            builder.Services.AddScoped<ICourseDAL, EFCourseDAL>();
            builder.Services.AddScoped<ICourseService, CourseManager>();

            builder.Services.AddScoped<ISocialMediaDAL, EFSocialMediaDAL>();
            builder.Services.AddScoped<ISocialMediaService, SocialMediaManager>();

            builder.Services.AddScoped<IContactDAL, EFContactDAL>();
            builder.Services.AddScoped<IContactService, ContactManager>();

            builder.Services.AddScoped<IAboutDAL, EFAboutDAL>();
            builder.Services.AddScoped<IAboutService, AboutManager>();

            builder.Services.AddScoped<IFeatureDAL, EFFeatureDAL>();
            builder.Services.AddScoped<IFeatureService, FeatureManager>();

            builder.Services.AddScoped<IServiceDAL, EFServiceDAL>();
            builder.Services.AddScoped<IServiceService, ServiceManager>();

            builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();

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
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}