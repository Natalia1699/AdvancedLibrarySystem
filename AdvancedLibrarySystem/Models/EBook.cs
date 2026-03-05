namespace AdvancedLibrarySystem.Models
{
    public class EBook : Book
    {
        public double FileSizeMB { get; set; }

        public EBook(string title, string author, int year, double fileSize)
            : base(title, author, year)
        {
            FileSizeMB = fileSize;
        }

        public override string GetDescription()
        {
            return $"EBook: {Title}, Size: {FileSizeMB} MB";
        }
    }
}