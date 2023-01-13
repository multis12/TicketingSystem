using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Core.Contracts;
using TicketingSystem.Core.Models.Tickets;
using TicketingSystem.Infrastructure.Data;
using TicketingSystem.Infrastructure.Data.Common;
using Type = TicketingSystem.Infrastructure.Data.Type;

namespace TicketingSystem.Core.Services
{
    public class TicketService : ITicketService
    {
        private readonly IRepository repo;
        private readonly IHostingEnvironment environment;

        public TicketService(IRepository _repo, IHostingEnvironment _environment)
        {
            repo = _repo;
            environment = _environment;
        }

        public async Task<IEnumerable<TicketConditionModel>> AllTicketConditions()
        {
            var ticketConditions = new List<TicketConditionModel>();

            ticketConditions = await repo.AllReadonly<TicketCondition>()
                .Select(x => new TicketConditionModel()
                {
                    Id = x.Id,
                    Name = x.Name
                })
                .ToListAsync();

            return ticketConditions;
        }

        public async Task<IEnumerable<TicketTypeModel>> AllTicketTypes()
        {
            var ticketTypes = new List<TicketTypeModel>();

            ticketTypes = await repo.AllReadonly<Type>()
                .Select(x => new TicketTypeModel()
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToListAsync();

            return ticketTypes;
        }

        public async Task Create(TicketModel model, IFormFile file)
        {
            var filePath = Path.Combine(environment.ContentRootPath, @"wwwroot\files", file.FileName);
            using var fileStream = new FileStream(filePath, FileMode.Create);
            await file.CopyToAsync(fileStream);
            var user = await repo.GetByIdAsync<AppUser>(model.UserId);
            var ticket = new Ticket()
            {
                Id = model.Id,
                DateAndTime = model.DateAndTime,
                ConditionId = model.ConditionId,
                Description = model.Description,
                Messages = model.Messages,
                Title = model.Title,
                TypeId = model.TypeId,
                FilePath = filePath,
                UserId = model.UserId,
                User = user
            };

            await repo.AddAsync(ticket);
            await repo.SaveChangesAsync();
        }
    }
}
