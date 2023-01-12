using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketingSystem.Infrastructure.Data
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public string FilePath { get; set; }

        [Required]
        public DateTime DateAndTime { get; set; }

        public string UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public AppUser? User { get; set; }

        public int TypeId { get; set; }

        [ForeignKey(nameof(TypeId))]
        public Type Type { get; set; }

        public int ConditionId { get; set; }

        [ForeignKey(nameof(ConditionId))]
        public Condition Condition { get; set; }

        public List<Message> Messages { get; set; } = new List<Message>();
    }
}
