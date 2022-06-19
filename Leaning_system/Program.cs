using Leaning_system.DBContext;
using Leaning_system.IRepo;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

});

builder.Services.AddScoped<IPower, PowerRepo>();
builder.Services.AddScoped<IStudent, StudentRepo>();
builder.Services.AddScoped<ITeacher, TeacherRepo>();
builder.Services.AddScoped<ISubject, SubectsRepo>();
builder.Services.AddScoped<ITest_schedule, Test_ScheduleRepo>();
builder.Services.AddScoped<IClass, ClassRepo>();
builder.Services.AddScoped<IExaml, ExamlRepo>();
builder.Services.AddScoped<IChat, ChatRepo>();
builder.Services.AddScoped<IScord, ScordRepo>();
builder.Services.AddScoped<ICourse, CoursesRepo>();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
