using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Infrastructure.Data;

namespace TicketingSystem.Core.Models.Account
{
    public class AccountEditModel
    {
        public string? Id { get; set; }

        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [Display(Name = "Second Name")]
        public string? SecondName { get; set; }

        [Display(Name = "Username")]
        public string? UserName { get; set; }

        [Display(Name = "Email")]
        public string? Email { get; set; }

        [Display(Name = "Account Request Role")]
        public int AccountRequestRoleId { get; set; }

        [DataType(DataType.Password)]
        public string? Password { get; set; }

        //[DataType(DataType.Password)]
        //public string? NewPassword { get; set; }

        public IEnumerable<AccountRequestRoleModel> AccountRequestRoles { get; set; } = new List<AccountRequestRoleModel>();
    }
}
