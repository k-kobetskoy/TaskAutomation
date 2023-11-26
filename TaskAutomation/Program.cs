using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TaskAutomation.BusinessLogic.Services;
using TaskAutomation.BusinessLogic.Services.Abstract;
using TaskAutomation.DAL;
using TaskAutomation.DAL.Services;
using TaskAutomation.Domain.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

#region Data

builder.Services.AddDbContext<TaskAutomationIdentityDbContext>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Identity")!));

builder.Services.AddDbContext<TaskAutomationBusinessDbContext>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Business")!));

builder.Services.AddScoped<TaskAutomationIdentityDbInitializer>();
builder.Services.AddScoped<TaskAutomationBusinessDbInitializer>();
#endregion

#region Identity
builder.Services.AddIdentity<User, Role>()
    .AddEntityFrameworkStores<TaskAutomationIdentityDbContext>()
    .AddDefaultTokenProviders();
#endregion

#region Automapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
#endregion


#region Services

builder.Services.AddSingleton<ITemplateService, TemplateService>();

#endregion

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

using (var serviceScope = app.Services.CreateScope())
{
    var services = serviceScope.ServiceProvider;

    services.GetRequiredService<TaskAutomationIdentityDbInitializer>().Initialize();
    services.GetRequiredService<TaskAutomationBusinessDbInitializer>().Initialize();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
