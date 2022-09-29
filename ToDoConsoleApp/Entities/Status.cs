namespace ToDoConsoleApp.Entities
{
    public class Status
    {
        public Status(string name)
        {
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Status status &&
                   Id == status.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id} - {nameof(Name)}: {Name}";
        }
    }
}
