using System.Text;

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
        public string Comments { get; set; }
        public DateTime CreatedAt { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder($"{Id} | {Name} | {DateFrom:yyyy-MM-dd} | {DateTo:yyyy-MM-dd} |        {Priority}     |   {Status.Name} |      {Comments}          |     {CreatedAt:yyyy-MM-dd} |        ");
            Categories.ForEach(c => sb.Append($"{c.Name} "));

            return sb.ToString();
        }
    }
}
