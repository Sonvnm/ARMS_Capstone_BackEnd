using ARMS_API.Config;
using ARMS_API.Helper;
using ARMS_API.ValidData;
using Data.ArmsContext;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Repository;
using Repository.MajorRepo;
using Service;
using Service.AccountSer;
using Service.AdmissionInformationSer;
using Service.AdmissionTimeSer;
using Service.BlogSer;
using Service.CampusSer;
using Service.EmailSer;
using Service.LocationSer;
using Service.MajorSer;
using Service.PayFeeAdmissionSer;
using Service.PriorityService;
using Service.RequestChangeMajorSer;
using Service.RequestNotificationSer;
using Service.StudentConsultationSer;
using Service.StudentProfileServ;
using Service.VnPaySer;
using Swashbuckle.AspNetCore.Filters;
using System.Text;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;
// Add services to the container.
builder.Services.AddDbContext<ArmsDbContext>(options => options.UseSqlServer(
    configuration.GetConnectionString("ArmsConnectionString")
));

// create mapper
var mapper = AutoMapperConfig.Initialize();
builder.Services.AddSingleton(mapper);

// For Identity
builder.Services.AddIdentity<Account, IdentityRole<Guid>>()
    .AddEntityFrameworkStores<ArmsDbContext>()
    .AddDefaultTokenProviders();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// Adding Authentication
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})
// Adding Jwt Bearer
.AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.RequireHttpsMetadata = false;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = configuration["JWT:ValidAudience"],
        ValidIssuer = configuration["JWT:ValidIssuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"])),
        ValidateLifetime = true,
        ClockSkew = TimeSpan.FromDays(5)
    };
});
builder.Services.AddMemoryCache();
builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowHttpOrigins", policy =>
    {
        // Add localhost:3000 to the allowed origins
        policy.WithOrigins("https://localhost:5001", "http://localhost:3000") // Allow React's frontend
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});


builder.Services.AddSwaggerGen(config =>
{
    config.SwaggerDoc("v1", new OpenApiInfo { Title = "Swagger ARMS", Version = "v1" });
    config.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "@JWT Authorization header using the Bearer schema. \r\n\r\n" +
            "Enter 'Bearer' [Space] and then your token in the text input below. \r\n\r\n" +
            "Example: 123456abcdef",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    config.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                },
                Scheme = "oauth2",
                Name = "Bearer",
                In = ParameterLocation.Header,
            },
            new List<string>()
        }
    });
});
builder.Services.Configure<VNPaySettings>(configuration.GetSection("VNPay"));
builder.Services.Configure<EmailSetting>(configuration.GetSection("EmailSettings"));

//builder.Services.AddHttpsRedirection(options =>
//{
//    options.HttpsPort = 5001;
//});

//Config Repository 
builder.Services.AddSingleton<TokenHealper>();
builder.Services.AddScoped<UserInput>();
builder.Services.AddScoped<ValidStudentConsultation>();
builder.Services.AddScoped<ValidRegisterAdmission>();
builder.Services.AddScoped<ValidBlog>();
builder.Services.AddScoped<ValidMajor>();
builder.Services.AddScoped<ValidAdmissionTime>();
builder.Services.AddScoped<ValidAdmissionInformation>();

builder.Services.AddScoped<ICampusService, CampusService>();
builder.Services.AddScoped<IMajorService, MajorService>();
builder.Services.AddScoped<IBlogService, BlogService>();
builder.Services.AddScoped<IStudentConsultationService, StudentConsultationService>();
builder.Services.AddScoped<IStudentProfileService, StudentProfileService>();
builder.Services.AddScoped<IAdmissionTimeService, AdmissionTimeService>();
builder.Services.AddScoped<IAdmissionInformationService, AdmissionInformationService>();
builder.Services.AddScoped<IRequestService, RequestService>();
builder.Services.AddScoped<IPriorityService, PriorityService>();
builder.Services.AddScoped<IPayFeeAdmissionService, PayFeeAdmissionService>();
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<IRequestNotificationService, RequestNotificationService>();
builder.Services.AddScoped<EmailQueue>();
builder.Services.AddSingleton<FirebaseService>();
//Services
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<IVnPayService, VnPayService>();

builder.Services.AddHttpClient(); // Thêm HttpClient vào DI container
builder.Services.AddScoped<ILocationService, LocationService>();
// app
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseCors("AllowHttpOrigins");
// Authentication & Authorization
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();