using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using TicketingSystem.Core.Contracts;
using TicketingSystem.Core.Models.Messages;
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

        public async Task Create(TicketModel model, IFormFile file, string userId, int projectId)
        {
            string? filePath = String.Empty;
            if (file != null)
            {
                filePath = Path.Combine(environment.ContentRootPath, @"wwwroot\files", file.FileName);
                using var fileStream = new FileStream(filePath, FileMode.Create);
                await file.CopyToAsync(fileStream);
            }

            var project = await repo.All<Project>()
                .Where(x => x.Id == projectId)
                .Include(x => x.Tickets)
                .FirstAsync();

            var user = await repo.GetByIdAsync<AppUser>(userId);

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
                UserId = user.Id,
                User = user
            };

            project.Tickets.Add(ticket);

            await repo.AddAsync(ticket);
            await repo.SaveChangesAsync();
        }

        public async Task Delete(int Id)
        {
            var ticket = await repo.GetByIdAsync<Ticket>(Id);
            ticket.IsActive = false;

            await repo.SaveChangesAsync();
        }

        public async Task<TicketDetailsModel> DetailsById(int Id)
        {
            return await repo.All<Ticket>()
                    .Where(x => x.IsActive == true)
                    .Where(x => x.Id == Id)
                    .Include(x => x.Messages)
                    .Select(x => new TicketDetailsModel()
                    {
                        Id = x.Id,
                        Title = x.Title,
                        Description = x.Description,
                        DateAndTime = x.DateAndTime,
                        Condition = x.Condition.Name,
                        Email = x.User.Email,
                        FilePath = x.FilePath,
                        FirstName = x.User.FirstName,
                        SecondName = x.User.SecondName,
                        Type = x.Type.Name,
                        Messages = x.Messages.Select(a => new MessageServiceModel()
                        {
                            DateAndTime = a.DateAndTime,
                            Condition = a.Condition.Name,
                            Description = a.Description,
                            Email = a.Author.Email,
                            FilePath = a.FilePath,
                            FirstName = a.Author.FirstName,
                            Id = a.Id,
                            SecondName = a.Author.SecondName
                        })
                        .OrderByDescending(x => x.DateAndTime)
                        .ToList()
                    }).FirstAsync();
        }

        public async Task Edit(TicketEditModel model, int ticketId)
        {
            var ticket = await repo.GetByIdAsync<Ticket>(ticketId);

            ticket.ConditionId = model.ConditionId;
            ticket.TypeId = model.TypeId;

            await repo.SaveChangesAsync();
        }

        public async Task<int> GetTicketConditionId(int ticketId)
        {
            return (await repo.GetByIdAsync<Ticket>(ticketId)).ConditionId;
        }

        public async Task<int> GetTicketTypeId(int ticketId)
        {
            return (await repo.GetByIdAsync<Ticket>(ticketId)).TypeId;
        }

        public async Task<IEnumerable<TicketServiceModel>> Mine(string userId)
        {
            return await repo.AllReadonly<Ticket>()
                .Where(t => t.UserId == userId)
                .Where(t => t.IsActive == true)
                .Select(t => new TicketServiceModel()
                {
                    DateAndTime = t.DateAndTime,
                    Condition = t.Condition.Name,
                    Title = t.Title,
                    Description = t.Description,
                    FilePath = t.FilePath,
                    Type = t.Type.Name,
                    Email = t.User.Email,
                    FirstName = t.User.FirstName,
                    Id = t.Id,
                    Messages = t.Messages,
                    SecondName = t.User.SecondName

                })
                .ToListAsync();
        }
    }
}
