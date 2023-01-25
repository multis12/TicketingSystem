using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace TicketingSystem.Core.Models.Messages
{
    public class MessageModel
    {
        public int Id { get; set; }

        public DateTime? DateAndTime { get; set; } = DateTime.Now;

        public string? AuthorId { get; set; }

        [Display(Name = "Condition")]
        public int ConditionId { get; set; }

        public IEnumerable<MessageConditionModel> Conditions { get; set; } = new List<MessageConditionModel>();

        [Required]
        [StringLength(3000)]
        public string Description { get; set; }

        public IFormFile? FilePath { get; set; }
    }
}
