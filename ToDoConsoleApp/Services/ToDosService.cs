using ToDoConsoleApp.Entities;
using ToDoConsoleApp.Repositories;

namespace ToDoConsoleApp.Services
{
    public class ToDosService : IToDosService
    {
        private readonly IToDosRepository _todosRepository;

        public ToDosService()
        {
            _todosRepository = new ToDosRepository();
        }
        public void Add(List<Category> categories)
        {
            int id = _todosRepository.Count() + 1;

            Console.WriteLine("Name:");
            string name = Console.ReadLine();

            Console.WriteLine("****Categories*****");
            categories.ForEach(c => Console.WriteLine(c));
            Console.WriteLine("*******************");

            Console.WriteLine("Categories Ids (separated by a comma): ");
            var categoriesIds = Console.ReadLine().Split(",")
                .ToList()
                .Select(c => int.Parse(c))
                .ToList();

            var selectedCategories = categories
                .Where(c => categoriesIds.Contains(c.Id))
                .ToList();

            Console.WriteLine("Date from [YYYY-MM-dd]: ");
            DateTime dateFrom = DateTime.Now;
            if(DateTime.TryParse(Console.ReadLine(), out DateTime dateFromParsed))
            {
                dateFrom = dateFromParsed;
            }

            Console.WriteLine("Date to [YYYY-MM-dd]: ");
            DateTime dateTo = DateTime.Now;
            if (DateTime.TryParse(Console.ReadLine(), out DateTime dateToParsed))
            {
                dateTo = dateToParsed;
            }

            Console.WriteLine("Priority (1-10): ");
            int priority = 5;
            if(int.TryParse(Console.ReadLine(), out int priorityParsed) &&
                priorityParsed >+ 1 && priorityParsed <=10)
            {
                priority = priorityParsed;
            }

            Console.WriteLine("Comments: ");
            string comments = Console.ReadLine();

            _todosRepository.Add(new Entities.ToDo()
            {
                Id = id,
                Name = name,
                Categories = selectedCategories,
                DateFrom = dateFrom,
                DateTo = dateTo,
                Priority = priority,
                StatusId = 1,
                Comments = comments,
                CreatedAt = DateTime.Now,
            });

            Console.WriteLine("Todo has been added successful!");
        }

        public void GetAll()
        {
           var todos = _todosRepository.GetAll();
           todos.ForEach(todo => Console.WriteLine(todo));
        }

        public void Remove()
        {
            Console.WriteLine("To do id to remove: ");
            if(int.TryParse(Console.ReadLine(), out int id))
            {
                _todosRepository.Remove(id);
                Console.WriteLine("To do has been removed!");
            }
            else
            {
                Console.WriteLine("Incorrect id!");  
            }
        }
    }
}
