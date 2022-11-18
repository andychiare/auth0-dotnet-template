using Microsoft.AspNetCore.Authentication.JwtBearer;
#if (!removeOpenAPI)
using Microsoft.OpenApi.Models;
#endif

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
     .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
     {
       options.Authority = $"https://{builder.Configuration["Auth0:Domain"]}";
       options.TokenValidationParameters =
         new Microsoft.IdentityModel.Tokens.TokenValidationParameters
         {
           ValidAudience = builder.Configuration["Auth0:Audience"],
           ValidIssuer = $"{builder.Configuration["Auth0:Domain"]}"
         };
     });

builder.Services.AddControllers();
#if (!removeOpenAPI)
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
  options.SwaggerDoc("v1", new OpenApiInfo { Title = "Auth0WebAPI", Version = "v1.0.0" });

  var securitySchema = new OpenApiSecurityScheme
  {
    Description = "Using the Authorization header with the Bearer scheme.",
    Name = "Authorization",
    In = ParameterLocation.Header,
    Type = SecuritySchemeType.Http,
    Scheme = "bearer",
    Reference = new OpenApiReference
    {
      Type = ReferenceType.SecurityScheme,
      Id = "Bearer"
    }
  };

  options.AddSecurityDefinition("Bearer", securitySchema);

  options.AddSecurityRequirement(new OpenApiSecurityRequirement
          {
              { securitySchema, new[] { "Bearer" } }
          });
});
#endif

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
#if (!removeOpenAPI)
  app.UseSwagger();
  app.UseSwaggerUI();
#endif
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
