using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Core.Contracts;
using TicketingSystem.Core.Models.Messages;
using TicketingSystem.Infrastructure.Data.Common;

namespace TicketingSystem.Core.Services
{
    public class MessageService : IMessageService
    {
        private readonly IRepository repo;
        public MessageService(IRepository _repo)
        {
            repo = _repo;
        }

        public Task Create(MessageServiceModel model)
        {
            throw new NotImplementedException();
        }
    }
}
