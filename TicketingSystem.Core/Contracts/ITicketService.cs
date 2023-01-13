using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Core.Models.Tickets;

namespace TicketingSystem.Core.Contracts
{
    public interface ITicketService
    {
        Task Create(TicketModel model, IFormFile file);

        Task<IEnumerable<TicketConditionModel>> AllTicketConditions();

        Task<IEnumerable<TicketTypeModel>> AllTicketTypes();
    }
}
