using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using TicketingSystem.Infrastructure.Data;

namespace TicketingSystem.Core.Models.Tickets
{
    public class TicketModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(2000)]
        public string Description { get; set; }

        public IFormFile? FilePath { get; set; }

        public DateTime? DateAndTime { get; set; } = DateTime.Now;

        public string? UserId { get; set; }

        [Display(Name = "Type")]
        public int TypeId { get; set; }

        public IEnumerable<TicketTypeModel> Types { get; set; } = new List<TicketTypeModel>();

        [Display(Name = "Condition")]
        public int ConditionId { get; set; }

        public IEnumerable<TicketConditionModel> Conditions { get; set; } = new List<TicketConditionModel>();

        public List<Message> Messages { get; set; } = new List<Message>();
    }
}
