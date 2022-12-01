using Microsoft.AspNetCore.Authentication.JwtBearer;
#if (!removeOpenAPI)
using Microsoft.OpenApi.Models;
#endif

var builder = WebApplication.CreateBuilder(args);

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
builder.Services.AddSwaggerService();
#endif

var app = builder.Build();

#if (!removeOpenAPI)
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}
#endif

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
