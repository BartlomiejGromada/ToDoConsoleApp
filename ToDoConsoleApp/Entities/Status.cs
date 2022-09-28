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

        public override string ToString()
        {
            return $"Id: {Id} - Name: {Name}";
        }
    }
}
