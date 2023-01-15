using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Core.Contracts;
using TicketingSystem.Core.Models.Messages;
using TicketingSystem.Infrastructure.Data;
using TicketingSystem.Infrastructure.Data.Common;

namespace TicketingSystem.Core.Services
{
    public class MessageService : IMessageService
    {
        private readonly IRepository repo;
        private readonly IHostingEnvironment environment;

        public MessageService(IRepository _repo, IHostingEnvironment _environment)
        {
            repo = _repo;
            environment = _environment;
        }

        public async Task Create(MessageModel model, IFormFile file, string userId, int ticketId)
        {
            var filePath = Path.Combine(environment.ContentRootPath, @"wwwroot\messageFiles", file.FileName);
            using var fileStream = new FileStream(filePath, FileMode.Create);
            await file.CopyToAsync(fileStream);

            var ticket = await repo.All<Ticket>()
                .Where(x => x.Id == ticketId)
                .Include(x => x.Messages)
                .FirstAsync();

            var user = await repo.GetByIdAsync<AppUser>(userId);

            var message = new Message()
            {
                Author = user,
                AuthorId = user.Id,
                DateAndTime = model.DateAndTime,
                ConditionId = model.ConditionId,
                Description = model.Description,
                FilePath = filePath,
                Id = model.Id
            };

            ticket.Messages.Add(message);

            await repo.AddAsync(message);
            await repo.SaveChangesAsync();
        }

        public async Task<IEnumerable<MessageConditionModel>> GetAllMessageTypes()
        {
            var messageTypes = await repo.AllReadonly<MessageCondition>()
                .Select(x => new MessageConditionModel()
                {
                    Id = x.Id,
                    Name = x.Name
                })
                .ToListAsync();

            return messageTypes;
        }
    }
}
