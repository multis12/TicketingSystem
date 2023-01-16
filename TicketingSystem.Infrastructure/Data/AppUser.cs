using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public bool IsActive { get; set; } = true;
    }
}
