
namespace SPN.Web
{
    using AutoMapper;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using System.Linq;
    using SPN.Services.Mapping;
    using SPN.Web.Extensions;
    using SPN.Forum.Data.Seeding;
    using SPN.Forum.Data;
    using SPN.Forum.Data.Models.Identity;
    using SPN.Forum.Services.Contracts;
    using SPN.Forum.Services.Services;
    using SPN.Services.Shared;
    using SPN.Auto.Services.Contracts;
    using SPN.Auto.Services.Services;
    using SPN.Data.Seeding;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<SPNDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<SPNDbContext>()
                .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                // Password settings.
                
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 3;
                options.Password.RequiredUniqueChars = 0;

                options.User.RequireUniqueEmail = false;

            });

            services
                 .ConfigureApplicationCookie(options =>
                 {
                     options.LoginPath = "/Identity/Account/Login";
                     options.LogoutPath = "/Identity/Account/Logout";
                    
                 });

            services.AddAutoMapper(AutoMapperConfig.GetAutoMapperProfilesFromAllAssemblies()
             .ToArray());
            services.AddScoped<SPNUserRoleSeeder>();
            services.AddScoped<SPNCategorySeeder>();
            services.AddScoped<SPNConciseAutoSeed>();

            //Forum Services
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IPostService, PostService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IReplyService, ReplyService>();
            services.AddScoped<IQuoteService, QuoteService>();


            //Auto Services
            services.AddScoped<IMakeService, MakeService>();
            services.AddScoped<IModelService, ModelService>();
            services.AddScoped<IAutoService, AutoService>();

            //Shared Services
            services.AddScoped<IUserProfileService, UserProfileService>();

            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDatabaseSeeding();

            using (var scope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            using (var dbContext = scope.ServiceProvider.GetService<SPNDbContext>())

                dbContext.Database.EnsureCreated();
             

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                 name: "category",
                 pattern: "{controller=Category}/{action=Index}/{id?}");
                endpoints.MapRazorPages();

            });
        }
    }
}
