namespace ToDoConsoleApp.Entities
{
    public class Category
    {
        public Category(string name)
        {
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ToDo> ToDos { get; set; } = new List<ToDo>();

        public override bool Equals(object obj)
        {
            return obj is Category category &&
                   Id == category.Id &&
                   Name == category.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id} - {nameof(Name)}: {Name}";
        }
    }
}
