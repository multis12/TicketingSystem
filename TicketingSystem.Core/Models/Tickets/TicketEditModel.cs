using System.ComponentModel.DataAnnotations;
using TicketingSystem.Core.Models.Messages;

namespace TicketingSystem.Core.Models.Tickets
{
    public class TicketEditModel
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string? Title { get; set; }

        [StringLength(2000)]
        public string? Description { get; set; }

        public string? FilePath { get; set; }

        public DateTime? DateAndTime { get; set; }

        public string? FirstName { get; set; }

        public string? SecondName { get; set; }

        public string? Email { get; set; }

        [Display(Name = "Type")]
        public int TypeId { get; set; }

        public IEnumerable<TicketTypeModel> Types { get; set; } = new List<TicketTypeModel>();

        [Display(Name = "Condition")]
        public int ConditionId { get; set; }

        public IEnumerable<TicketConditionModel> Conditions { get; set; } = new List<TicketConditionModel>();

        public List<MessageServiceModel> Messages { get; set; } = new List<MessageServiceModel>();
    }
}
