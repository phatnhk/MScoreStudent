using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MScoreStudent.Infrastructure.DbContexts;
using MScoreStudent.Infrastructure.Identity.Models;

namespace MScoreStudent.Web.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRouting(options => options.LowercaseUrls = true);
            services.AddPersistenceContexts(configuration);
        }
        private static void AddPersistenceContexts(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<IdentityContext>(options =>
                    options.UseInMemoryDatabase("IdentityDb"));
            }
            else
            {
                services.AddDbContext<IdentityContext>(options => options.UseSqlServer(configuration.GetConnectionString("IdentityConnection")));
            }
            //services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            //{
            //    options.SignIn.RequireConfirmedAccount = true;
            //    options.Password.RequireNonAlphanumeric = false;
            //}).AddEntityFrameworkStores<IdentityContext>().AddDefaultUI().AddDefaultTokenProviders();
        }
    }
}
