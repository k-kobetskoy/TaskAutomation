using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;
using TaskAutomation.BusinessLogic.Services;
using TaskAutomation.BusinessLogic.Services.Abstract;
using TaskAutomation.DAL;
using TaskAutomation.DAL.Services;
using TaskAutomation.Domain.Identity;
using TaskAutomation.Models.Constants;
using TaskAutomation.Services;
using TaskAutomation.Services.Abstract;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

#region Data

builder.Services.AddDbContext<TaskAutomationIdentityDbContext>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString(ConfigurationKeys.IdentityConnectionStringName)!));

builder.Services.AddDbContext<TaskAutomationBusinessDbContext>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString(ConfigurationKeys.BusinessConnectionStringName)!));

builder.Services.AddScoped<TaskAutomationIdentityDbInitializer>();
builder.Services.AddScoped<TaskAutomationBusinessDbInitializer>();
#endregion

#region Identity
builder.Services.AddIdentity<User, Role>()
    .AddEntityFrameworkStores<TaskAutomationIdentityDbContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(opt =>
{
#if DEBUG
    opt.Password.RequiredLength = 3;
    opt.Password.RequireDigit = false;
    opt.Password.RequireLowercase = false;
    opt.Password.RequiredUniqueChars = 3;
    opt.Password.RequireUppercase = false;
    opt.Password.RequireNonAlphanumeric = false;
    opt.User.RequireUniqueEmail = true;
#endif
});

#endregion

#region Automapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
#endregion

#region Authentication/Authorization

builder.Services.AddAuthentication(opt =>
{
    opt.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,

        //ValidIssuer = "https://localhost:5001",
        //ValidAudience = "https://localhost:5001", 
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration[ConfigurationKeys.JwtKey]!)),
        ClockSkew = TimeSpan.Zero,
    };
});


builder.Services.AddAuthorization(opt =>
{
    opt.AddPolicy(Policies.IsAdmin, policy => policy.RequireClaim(ClaimTypes.Role, AdminUserConstants.RoleName));
});

#endregion



#region Services

builder.Services.AddSingleton<ITemplateService, TemplateService>();
builder.Services.AddSingleton<ITokenService, TokenService>();

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
