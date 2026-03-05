namespace AdvancedLibrarySystem.Models
{
    public class AudioBook : Book
    {
        public int DurationMinutes { get; set; }

        public AudioBook(string title, string author, int year, int duration)
            : base(title, author, year)
        {
            DurationMinutes = duration;
        }

        public override string GetDescription()
        {
            return $"AudioBook: {Title}, Duration: {DurationMinutes} min";
        }
    }
}