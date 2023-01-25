using Microsoft.AspNetCore.Http;
using TicketingSystem.Core.Models.Tickets;

namespace TicketingSystem.Core.Contracts
{
    public interface ITicketService
    {
        Task Create(TicketModel model, IFormFile file, string userId, int projectId);

        Task<IEnumerable<TicketConditionModel>> AllTicketConditions();

        Task<IEnumerable<TicketTypeModel>> AllTicketTypes();

        Task Delete(int Id);

        Task<TicketDetailsModel> DetailsById(int Id);

        Task Edit(TicketEditModel model, int ticketId);

        Task<int> GetTicketConditionId(int ticketId);

        Task<int> GetTicketTypeId(int ticketId);

        Task<IEnumerable<TicketServiceModel>> Mine(string userId);
    }
}
