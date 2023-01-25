using System.ComponentModel.DataAnnotations;

namespace TicketingSystem.Core.Models.Account
{
    public class AccountDeleteModel
    {
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [Display(Name = "Second Name")]
        public string? SecondName { get; set; }

        [Display(Name = "Username")]
        public string? UserName { get; set; }

        [Display(Name = "Email")]
        public string? Email { get; set; }
    }
}
