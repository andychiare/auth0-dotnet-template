using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Auth0.WebAPI.Swagger
{
    public static class SwaggerExtension
    {
        public static IServiceCollection AddSwaggerGenerator(this IServiceCollection services)
        {
            return services.AddSwaggerGen(c =>
            {
                c.AddSecurityDefinition("OAuth2", new OpenApiSecurityScheme
                {
                    Description = "Standard Authorization header using the Bearer scheme. Example: \"bearer {token}\"",
                    In = ParameterLocation.Header,
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });
                c.OperationFilter<SecurityRequirementsOperationFilter>();
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Auth0.WebAPI", Version = "v1" });
            });
        }
    }
}
