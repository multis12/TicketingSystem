using System.ComponentModel.DataAnnotations;

namespace TicketingSystem.Infrastructure.Data
{
    public class AccountRequestRole
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
