using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TicketingSystem.Core.Contracts;
using TicketingSystem.Core.Models.Project;
using TicketingSystem.Core.Models.Tickets;
using TicketingSystem.Infrastructure.Data;
using TicketingSystem.Infrastructure.Data.Common;

namespace TicketingSystem.Core.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IRepository repo;
        private readonly UserManager<AppUser> userManager;

        public ProjectService(IRepository _repo, UserManager<AppUser> _userManager)
        {
            repo = _repo;
            userManager = _userManager;
        }

        public async Task<IEnumerable<ProjectViewModel>> All()
        {
            var result = new List<ProjectViewModel>();
            result = await repo.All<Project>()
                .Where(x => x.IsActive == true)
                .Select(x => new ProjectViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Tickets = x.Tickets
                })
                .ToListAsync();

            return result;
        }

        public async Task Create(ProjectModel model)
        {
            var project = new Project()
            {
                Name = model.Name,
                Description = model.Description,
            };
            await repo.AddAsync(project);
            await repo.SaveChangesAsync();
        }

        public async Task Delete(int projectId)
        {
            var project = await repo.GetByIdAsync<Project>(projectId);
            project.IsActive = false;

            await repo.SaveChangesAsync();
        }

        public async Task<ProjectDetailsModel> DetailsById(int Id, string userId)
        {
            var user = await repo.GetByIdAsync<AppUser>(userId);

            //var project = await repo.GetByIdAsync<Project>(Id);
            
            //var testProjectTickets = new List<TicketServiceModel>();

            //var projectTickets = await repo.All<Project>()
            //    .Where(p => p.Id == Id)
            //    .Include(p => p.Tickets.Select(t => new TicketServiceModel()
            //    {
            //        Id = t.Id,
            //        DateAndTime = t.DateAndTime,
            //        Condition = t.Condition.Name,
            //        Description = t.Description,
            //        Email = t.User.Email,
            //        FilePath = t.FilePath,
            //        FirstName = t.User.FirstName,
            //        Messages = t.Messages,
            //        SecondName = t.User.SecondName,
            //        Title = t.Title,
            //        Type = t.Type.Name
            //    }).ToList())
            //    .FirstAsync();

            
            //testProjectTickets = projectTickets.Tickets;

                //testProjectTickets = await repo.All<Ticket>()
                //.Select(a => new TicketServiceModel()
                //{
                //    DateAndTime = a.DateAndTime,
                //    Condition = a.Condition.Name,
                //    Description = a.Description,
                //    SecondName = a.User.SecondName,
                //    Email = a.User.Email,
                //    FilePath = a.FilePath,
                //    FirstName = a.User.FirstName,
                //    Id = a.Id,
                //    Messages = a.Messages,
                //    Title = a.Title,
                //    Type = a.Type.Name
                //})
                //.ToListAsync();


            //var allProjectTickets = new List<TicketServiceModel>();

            //allProjectTickets = projectTickets.Tickets;

            var clientTickets = new List<TicketServiceModel>();

            clientTickets = await repo.AllReadonly<Ticket>()
                .Where(c => c.IsActive == true)
                .Where(c => c.UserId == userId)
                .Select(c => new TicketServiceModel()
                {
                    DateAndTime = c.DateAndTime,
                    Condition = c.Condition.Name,
                    Type = c.Type.Name,
                    Description = c.Description,
                    Email = c.User.Email,
                    FilePath = c.FilePath,
                    FirstName = c.User.FirstName,
                    Id = c.Id,
                    Messages = c.Messages,
                    SecondName = c.User.SecondName,
                    Title = c.Title
                })
                .ToListAsync();

            if ((await userManager.IsInRoleAsync(user, "Client")) && !(await userManager.IsInRoleAsync(user, "Admin")) && !(await userManager.IsInRoleAsync(user, "Staff")))
            {
                return await repo.AllReadonly<Project>()
                    .Where(x => x.IsActive == true)
                    .Where(x => x.Id == Id)
                    .Include(x => x.Tickets)
                    .Select(x => new ProjectDetailsModel()
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Description = x.Description,
                        Tickets = clientTickets
                    }).FirstAsync();
            }
            else
            {
                return await repo.AllReadonly<Project>()
                    .Where(x => x.IsActive == true)
                    .Where(x => x.Id == Id)
                    .Include(x => x.Tickets)
                    .Select(x => new ProjectDetailsModel()
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Description = x.Description,
                        Tickets = x.Tickets.Where(a => a.IsActive == true).Select(a => new TicketServiceModel()
                        {
                            DateAndTime = a.DateAndTime,
                            Condition = a.Condition.Name,
                            Description = a.Description,
                            SecondName = a.User.SecondName,
                            Email = a.User.Email,
                            FilePath = a.FilePath,
                            FirstName = a.User.FirstName,
                            Id = a.Id,
                            Messages = a.Messages,
                            Title = a.Title,
                            Type = a.Type.Name
                        }).ToList()
                    }).FirstAsync();
            }
            
        }
    }
}
