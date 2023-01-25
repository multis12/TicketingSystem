using Microsoft.AspNetCore.Http;
using TicketingSystem.Core.Models.Messages;

namespace TicketingSystem.Core.Contracts
{
    public interface IMessageService
    {
        Task Create(MessageModel model, IFormFile file, string userId, int ticketId);

        Task<IEnumerable<MessageConditionModel>> GetAllMessageTypes();
    }
}
