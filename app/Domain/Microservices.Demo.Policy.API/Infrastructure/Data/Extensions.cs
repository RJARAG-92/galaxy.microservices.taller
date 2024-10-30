using Microservices.Demo.Policy.API.Infrastructure.Data.Context;
using Microservices.Demo.Policy.API.Infrastructure.Data.Repository;
using Microservices.Demo.Policy.API.Infrastructure.Data.UnitOfWork;
using Microsoft.EntityFrameworkCore; 

namespace Microservices.Demo.Policy.API.Infrastructure.Data
{
    public static class Extensions
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services, IConfiguration configuration)
        {
            var policyConnection = configuration.GetConnectionString("PolicyConnection");
            services.AddDbContext<PolicyDbContext>(options =>
            {
                options.UseSqlServer(policyConnection);
            });
            services.AddScoped<IUnitOfWork, UnitOfWork.UnitOfWork>();
            services.AddScoped<IPolicyVersionRepository, PolicyVersionRepository>();

            return services;
        }
    }
}
