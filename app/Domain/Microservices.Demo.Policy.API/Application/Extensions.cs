namespace Microservices.Demo.Policy.API.Application
{
    public static class Extensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<OfferApplicationService>();
            services.AddTransient<PolicyApplicationService>();
            services.AddTransient<PolicyVersionApplicationService>();

            return services;
        }
    }
}
