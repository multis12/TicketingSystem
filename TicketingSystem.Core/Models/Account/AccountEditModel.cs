using System.ComponentModel.DataAnnotations;

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

        public IEnumerable<AccountRequestRoleModel> AccountRequestRoles { get; set; } = new List<AccountRequestRoleModel>();
    }
}
