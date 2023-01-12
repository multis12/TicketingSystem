using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Core.Models.Project;

namespace TicketingSystem.Core.Contracts
{
    public interface IProjectService
    {
        Task<IEnumerable<ProjectViewModel>> All();

        Task<int> Create(ProjectModel model);
    }
}
