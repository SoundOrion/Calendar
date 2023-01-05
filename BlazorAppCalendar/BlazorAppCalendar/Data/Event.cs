namespace BlazorAppCalendar.Data
{
    public class Event
    {
        public int StackIndex { get; set; }

        public int SkipCount { get; set; }

        public int Id { get; set; }

        public string? Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string? Color { get; set; }

        public double Width { get; set; }
    }
}
