using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Core.Models.Account;
using TicketingSystem.Core.Models.Project;
using TicketingSystem.Core.Models.Tickets;

namespace TicketingSystem.Core.Contracts
{
    public interface IAccountService
    {
        Task<IEnumerable<AccountRequestRoleModel>> GetAllAccountRoles();

        Task<IEnumerable<AccountModel>> AllRequests();

        Task<IEnumerable<AccountModel>> All();

        Task Delete(string userId);

        Task Edit(AccountEditModel model, string userId);

        Task Approve(AccountModel model,string userId);

        Task<int> GetAccountRoleId(string userId);

        Task<AccountModel> DetailsById(string userId);
    }
}
