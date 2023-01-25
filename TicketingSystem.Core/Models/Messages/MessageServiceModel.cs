namespace TicketingSystem.Core.Models.Messages
{
    public class MessageServiceModel
    {
        public int Id { get; set; }

        public DateTime? DateAndTime { get; set; }

        public string? FirstName { get; set; }

        public string? SecondName { get; set; }

        public string? Email { get; set; }

        public string? Condition { get; set; }

        public string Description { get; set; }

        public string FilePath { get; set; }
    }
}
