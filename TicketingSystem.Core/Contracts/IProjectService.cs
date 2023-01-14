using TicketingSystem.Core.Models.Project;

namespace TicketingSystem.Core.Contracts
{
    public interface IProjectService
    {
        Task<IEnumerable<ProjectViewModel>> All();

        Task Create(ProjectModel model);

        Task Delete(int projectId);

        Task<ProjectDetailsModel> DetailsById(int Id, string userId);
    }
}
