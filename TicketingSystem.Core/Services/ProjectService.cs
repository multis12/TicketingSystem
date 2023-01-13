using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Core.Contracts;
using TicketingSystem.Core.Models.Project;
using TicketingSystem.Infrastructure.Data;
using TicketingSystem.Infrastructure.Data.Common;

namespace TicketingSystem.Core.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IRepository repo;

        public ProjectService(IRepository _repo)
        {
            repo = _repo;
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

        public async Task<ProjectModel> DetailsById(int Id)
        {
            return await repo.AllReadonly<Project>()
                .Where(x => x.IsActive == true)
                .Where(x => x.Id == Id)
                .Include(x => x.Tickets)
                .Select(x => new ProjectModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Tickets = x.Tickets
                }).FirstAsync();
        }
    }
}
