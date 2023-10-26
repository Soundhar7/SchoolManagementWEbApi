using SchoolManagementWEBAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<ISchoolService,SchoolService>();
builder.Services.AddScoped<IStudentService,StudentService>();
builder.Services.AddScoped<ITeacherService,TeacherService>();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
