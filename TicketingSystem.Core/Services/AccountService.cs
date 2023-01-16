using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Core.Contracts;
using TicketingSystem.Core.Models.Account;
using TicketingSystem.Core.Models.Messages;
using TicketingSystem.Core.Models.Project;
using TicketingSystem.Infrastructure.Data;
using TicketingSystem.Infrastructure.Data.Common;

namespace TicketingSystem.Core.Services
{
    public class AccountService : IAccountService
    {
        private readonly IRepository repo;
        private readonly UserManager<AppUser> userManager;

        public AccountService(IRepository _repo, UserManager<AppUser> _userManager)
        {
            repo = _repo;
            userManager = _userManager;
        }

        public async Task<IEnumerable<AccountRequestModel>> All()
        {
            var result = new List<AccountRequestModel>();
            result = await repo.All<AppUser>()
                .Where(x => x.IsActive == false)
                .Select(x => new AccountRequestModel()
                {
                    Id = x.Id,
                    AccountRequestRoleId = x.AccountRoleId,
                    Email = x.Email,
                    FirstName = x.FirstName,
                    SecondName = x.SecondName,
                    UserName = x.UserName
                })
                .ToListAsync();

            return result;
        }

        public async Task Approve(AccountRequestModel model, string userId)
        {
            var user = await repo.GetByIdAsync<AppUser>(model.Id);

            if (model.AccountRequestRoleId == 1 )
            {
                await userManager.AddToRoleAsync(user, "Administrator");
                await userManager.AddToRoleAsync(user, "Staff");
            }
            else if (model.AccountRequestRoleId == 3 )
            {
                await userManager.AddToRoleAsync(user, "Staff");
            }

            user.IsActive = true;
            await repo.SaveChangesAsync();
        }

        public async Task<AccountRequestModel> DetailsById(string userId)
        {
            var result = new AccountRequestModel();

            result = await repo.All<AppUser>()
                .Where(r => r.Id == userId)
                .Select(r => new AccountRequestModel()
                {
                    AccountRequestRoleId = r.AccountRoleId,
                    Email= r.Email,
                    FirstName= r.FirstName,
                    Id= r.Id,
                    SecondName = r.SecondName,
                    UserName = r.UserName
                })
                .FirstAsync();

            return result;
        }

        public async Task<IEnumerable<AccountRequestRoleModel>> GetAllAccountRoles()
        {
            var messageTypes = await repo.AllReadonly<AccountRequestRole>()
                .Select(x => new AccountRequestRoleModel()
                {
                    Id = x.Id,
                    Name = x.Name
                })
                .ToListAsync();

            return messageTypes;
        }

        public async Task<int> GetAccountRoleId(string userId)
        {
            return (await repo.GetByIdAsync<AppUser>(userId)).AccountRoleId;
        }
    }
}
