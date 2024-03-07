using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using EmsData.EmsDataContext;
using EmsData.Repository;
using EmsData.Services;
using EmsServices;
using EmsApi.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EmsDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ILoginService, LoginService>();
builder.Services.AddScoped<EmployeeService, EmployeeService>();
builder.Services.AddScoped<UserMasterService, UserMasterService>();
builder.Services.AddScoped<GradeMasterService, GradeMasterService>();
builder.Services.AddScoped<DepartmentService, DepartmentService>();
builder.Services.AddScoped<IUserMasterRepo, UserMasterRepo>();
builder.Services.AddScoped<IEmployeeRepo, EmployeeRepo>();
builder.Services.AddScoped<IGradeMasterRepo, GradeMasterRepo>();
builder.Services.AddScoped<IDepartmentRepo, DepartmentRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Configure CORS
app.UseCors(options =>
{
    options.AllowAnyOrigin();
    options.AllowAnyMethod();
    options.AllowAnyHeader();
});

app.UseAuthorization();

app.MapControllers();

app.Run();
