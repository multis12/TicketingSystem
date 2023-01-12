using TicketingSystem.Infrastructure.Data.Common;

namespace TicketingSystem.Extensions
{
    public static class TicketingSystemServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();


            return services;
        }
    }
}
