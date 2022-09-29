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
            var sb = new StringBuilder($@"{nameof(Id)}: {Id} - {nameof(Name)}: {Name} - {nameof(DateFrom)}: {DateFrom:yyyy-MM-dd} - {nameof(DateTo)}: {DateTo:yyyy-MM-dd} -
                        {nameof(Priority)}: {Priority} - {nameof(Status)}: {Status.Name} - {nameof(Comments)}: { Comments} -
                        {nameof(CreatedAt)}: {CreatedAt:yyyy-MM-dd}");
            sb.Append("\nCategories: ");
            Categories.ForEach(c => sb.Append($"{c.Name} "));
            return sb.ToString();
        }
    }
}
