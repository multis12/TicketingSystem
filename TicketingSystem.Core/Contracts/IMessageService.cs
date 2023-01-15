using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Core.Models.Messages;

namespace TicketingSystem.Core.Contracts
{
    public interface IMessageService
    {
        Task Create(MessageServiceModel model);
    }
}
