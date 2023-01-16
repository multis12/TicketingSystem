using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Infrastructure.Data
{
    public class AppUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string SecondName { get; set; }

        public int AccountRoleId { get; set; }

        [ForeignKey(nameof(AccountRoleId))]
        public AccountRequestRole AccountRole { get; set; }

        public bool IsActive { get; set; } = false;
    }
}
