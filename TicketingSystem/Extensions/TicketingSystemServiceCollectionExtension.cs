using TicketingSystem.Core.Contracts;
using TicketingSystem.Core.Services;
using TicketingSystem.Infrastructure.Data.Common;

namespace TicketingSystem.Extensions
{
    public static class TicketingSystemServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<ITicketService, TicketService>();
            services.AddScoped<IMessageService, MessageService>();
            services.AddScoped<IAccountService, AccountService>();


            return services;
        }
    }
}
