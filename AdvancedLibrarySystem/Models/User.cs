namespace AdvancedLibrarySystem.Models
{
    public class User
    {
        public string Name { get; }
        public Guid Id { get; }

        public User(string name)
        {
            Name = name;
            Id = Guid.NewGuid();
        }

        public override string ToString()
        {
            return $"{Name} ({Id})";
        }
    }
}