using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Infrastructure.Data;

namespace TicketingSystem.Core.Models.Account
{
    public class AccountEditModel : AppUser
    {
        public IEnumerable<AccountRequestRoleModel> AccountRequestRoles { get; set; } = new List<AccountRequestRoleModel>();
    }
}
