using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Core.Models.Project;
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
    }
}
