using Microsoft.EntityFrameworkCore;
using Online_Clinic_Management_System.DBCONTEXT;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//registering the connection string

builder.Services.AddDbContext<RegisterDbContext>
    (opations => opations.UseSqlServer(builder.Configuration.GetConnectionString("con")));

//Login
builder.Services.AddDbContext<LoginDbContext>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("con")));

//Prescription
builder.Services.AddDbContext<PrescriptionDbContext>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("con")));

//Patient
builder.Services.AddDbContext<PatientDbContext>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("con")));

//Labtest
builder.Services.AddDbContext<LabtestDbContext>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("con")));

//Doctor

builder.Services.AddDbContext<DoctorDbContext>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("con")));

//Laboratorian

builder.Services.AddDbContext<LaboratorianDbContext>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("con")));


//Receptionist
builder.Services.AddDbContext<ReceptionistDbContext>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("con")));





//doctor

//builder.Services.AddDbContext<DoctorDbContext>
//  (opations => opations.UseSqlServer(builder.Configuration.GetConnectionString("con")));

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
