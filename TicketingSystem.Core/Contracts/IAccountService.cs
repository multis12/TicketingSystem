using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Core.Models.Account;
using TicketingSystem.Core.Models.Project;

namespace TicketingSystem.Core.Contracts
{
    public interface IAccountService
    {
        Task<IEnumerable<AccountRequestRoleModel>> GetAllAccountRoles();

        Task<IEnumerable<AccountRequestModel>> All();

        Task Approve(AccountRequestModel model,string userId);

        Task<int> GetAccountRoleId(string userId);

        Task<AccountRequestModel> DetailsById(string userId);
    }
}
