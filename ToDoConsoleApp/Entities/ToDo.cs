namespace ToDoConsoleApp.Entities
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Category> Categories { get; set; } = new List<Category>();
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int Priority { get; set; }
        public Status Status { get; set; }
        public int StatusId { get; set; }
        public string Command { get; set; }
        public DateTime CreatedAt { get; set; }

        public override string ToString()
        {
            return $@"Id: {Id} - Name: {Name} - DateFrom: {DateFrom} - DateTo: {DateTo} -
                        Priority: {Priority} - Status: {Status.Name} - Command: { Command} -
                        CreatedAt: {CreatedAt}";
        }
    }
}
