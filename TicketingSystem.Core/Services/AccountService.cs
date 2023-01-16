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

        public async Task<IEnumerable<AccountModel>> AllRequests()
        {
            var result = new List<AccountModel>();
            result = await repo.All<AppUser>()
                .Where(x => x.IsActive == false)
                .Select(x => new AccountModel()
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

        public async Task Approve(AccountModel model, string userId)
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

            user.AccountRoleId = model.AccountRequestRoleId;

            user.IsActive = true;
            await repo.SaveChangesAsync();
        }

        public async Task<AccountModel> DetailsById(string userId)
        {
            var result = new AccountModel();

            result = await repo.All<AppUser>()
                .Where(r => r.Id == userId)
                .Select(r => new AccountModel()
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

        public async Task<IEnumerable<AccountModel>> All()
        {
            var result = new List<AccountModel>();
            result = await repo.All<AppUser>()
                .Where(x => x.IsActive == true)
                .Select(x => new AccountModel()
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

        public async Task Delete(string userId)
        {
            var user = await repo.GetByIdAsync<AppUser>(userId);

            var userTickets = await repo.All<Ticket>()
                .Where(u => u.UserId == userId)
                .ToListAsync();

            var userMessages = await repo.All<Message>()
                .Where(u => u.AuthorId == userId)
                .ToListAsync();

            foreach (var message in userMessages)
            {
                repo.Delete(message);
            }

            foreach (var ticket in userTickets)
            {
                repo.Delete(ticket);
            }

            repo.Delete(user);

            await repo.SaveChangesAsync();
        }

        public Task Edit(AccountEditModel model, string userId)
        {
            throw new NotImplementedException();
        }
    }
}
