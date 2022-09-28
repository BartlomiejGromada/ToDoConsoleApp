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

        public override string ToString()
        {
            return $"Id: {Id} - Name: {Name}";
        }
    }
}
