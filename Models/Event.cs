namespace SharedCalendar.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End  { get; set; }
        public string Color { get; set; }
    }
}