using TicketingSystem.Core.Models.Messages;

namespace TicketingSystem.Core.Models.Tickets
{
    public class TicketDetailsModel
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? FilePath { get; set; }

        public DateTime? DateAndTime { get; set; } = DateTime.Now;

        public string? FirstName { get; set; }

        public string? SecondName { get; set; }

        public string? Email { get; set; }

        public string? Type { get; set; }

        public string? Condition { get; set; }

        public List<MessageServiceModel> Messages { get; set; } = new List<MessageServiceModel>();
    }
}
