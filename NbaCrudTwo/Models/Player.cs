namespace NbaCrudTwo.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Team { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Position { get; set; } = string.Empty;
        public string Height { get; set; } = string.Empty;        
        public string College { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public DateOnly DraftYear { get; set; }        
    }
}
