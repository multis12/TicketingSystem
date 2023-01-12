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
            var result = await repo.All<Project>()
                .OrderBy(x => x.Name)
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

        public async Task<int> Create(ProjectModel model)
        {
            var project = new Project()
            {
                Name = model.Name,
                Description = model.Description,
            };
            await repo.AddAsync(project);
            await repo.SaveChangesAsync();

            return project.Id;
        }
    }
}
