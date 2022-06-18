using EsinavUygulamasi.DAL;
using EsinavUygulamasi.DAL.Models.Database;
using EsinavUygulamasi.Repository;
using EsinavUygulamasi.Service.Abstract;
using EsinavUygulamasi.Service.Concreate;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsinavUygulamasi
{
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
            services.AddControllersWithViews();
            services.AddDbContext<EsinavUygulamasiDbContext>(option =>
            {
                option.UseNpgsql(Configuration["ConnectionStrings:EsinavUygulamasiDbConnection"]);
            });
            services.AddTransient<IGenericRepository<User>, GenericRepository<User>>();
            services.AddTransient<IGenericRepository<Question>, GenericRepository<Question>>();
            services.AddTransient<IGenericRepository<Exam>, GenericRepository<Exam>>();
            services.AddTransient<IGenericRepository<Institution>, GenericRepository<Institution>>();
            services.AddTransient<IGenericRepository<Topic>, GenericRepository<Topic>>();
            services.AddTransient<IGenericRepository<Role>, GenericRepository<Role>>();
            services.AddTransient<IGenericRepository<UserRole>, GenericRepository<UserRole>>();
            services.AddTransient<IGenericRepository<Test>, GenericRepository<Test>>();
            services.AddTransient<IGenericRepository<TestQuestion>, GenericRepository<TestQuestion>>();
            services.AddTransient<IGenericRepository<UserTest>, GenericRepository<UserTest>>();
            services.AddTransient<IGenericRepository<UserTestInformationView>, GenericRepository<UserTestInformationView>>();
            services.AddTransient<IGenericRepository<UserInTheTest>, GenericRepository<UserInTheTest>>();
            services.AddTransient<IGenericRepository<UsersTestStatV>, GenericRepository<UsersTestStatV>>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IQuestionService, QuestionService>();
            services.AddTransient<IExamService, ExamService>();
            services.AddTransient<IinstitutionService, InstitutionService>();
            services.AddTransient<ITopicService, TopicService>();
            services.AddTransient<IRoleService, RoleService>();
            services.AddTransient<ITestService, TestService>();
            services.AddTransient<ITestQuestionService, TestQuestionService>();
            services.AddTransient<IUserTestSerevice, UserTestService>();



            services.AddMemoryCache();
            services.AddSession(option =>
            {
                option.IdleTimeout = TimeSpan.FromMinutes(20);
                option.Cookie.HttpOnly = true;
                option.Cookie.IsEssential = true;
            });
            services.AddMvc().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.PropertyNamingPolicy = null;
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
            app.UseSession();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                    name: "routeArea",
                    areaName: "Admin",
                    pattern: "Admin/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
                endpoints.MapAreaControllerRoute(
                    name: "routeArea",
                    areaName: "Student",
                    pattern: "Student/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
