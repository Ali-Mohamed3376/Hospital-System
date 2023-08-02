using Hospital.BL.Manager.Doctors;
using Hospital.DAL.Data.Context;
using Hospital.DAL.Repositories.Doctors;
using Hospital.DAL.Repositories.Issues;
using Hospital.DAL.Repositories.Patients;
using Hospital.DAL.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace HospitalMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            #region Services
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            var connectionString = builder.Configuration.GetConnectionString("Hospital_System");
            builder.Services.AddDbContext<HospitalContext>(option =>
                option.UseSqlServer(connectionString)
            );
            builder.Services.AddScoped<IDoctorRepo, DoctorRepo>();
            builder.Services.AddScoped<IPatientRepo, PatientRepo>();
            builder.Services.AddScoped<IIssuesRepo, IssueRepo>();

            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<IDoctorManager, DoctorManager>();

            #endregion

            #region Pipline
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
                pattern: "{controller=Hospital}/{action=Index}/{id?}");

            #endregion

            app.Run();
        }
    }
}