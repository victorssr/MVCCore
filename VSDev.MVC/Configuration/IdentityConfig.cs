using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VSDev.MVC.Data;

namespace VSDev.MVC.Configuration
{
    public static class IdentityConfig
    {

        public static IServiceCollection AddIdentityConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ContextBase>(options => options.UseSqlServer(configuration.GetConnectionString("VSDevDB")));

            services.AddDefaultIdentity<IdentityUser>()
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<ContextBase>();

            return services;
        }

        public static IServiceCollection AddAuthorizationConfig(this IServiceCollection services)
        {
            services.AddAuthorization(options =>
            {
                // AUTHORIZATION WITH POLICY
                options.AddPolicy("PodeExcluir", policy => policy.RequireClaim("PodeExcluir"));
            });

            return services;
        }

    }
}
