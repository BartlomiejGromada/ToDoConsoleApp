using ToDoConsoleApp.Entities;
using ToDoConsoleApp.Repositories;
using ToDoConsoleApp.Utils;

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

            CustomConsole.Success("Todo has been added successful!");
        }

        public void GetAll()
        {
            var todos = _todosRepository.GetAll();
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Id      Name             DateFrom         DateTo       Priority       Status                  Comments                CreatedAt                   Categories");
            todos.ForEach(todo => Console.WriteLine(todo));

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        }

        public void ChangeStatus(List<Status> statuses)
        {
            Console.WriteLine("****Statuses*****");
            statuses.ForEach(s => Console.WriteLine(s));
            Console.WriteLine("*****************");

            Console.WriteLine("Enter todo id and next status id:");
            if(int.TryParse(Console.ReadLine(), out int todoId) &&
                int.TryParse(Console.ReadLine(), out int statusId))
            {
                if(_todosRepository.GetById(todoId) != null
                    || !statuses.Any(s => s.Id == statusId))
                {
                    _todosRepository.ChangeStatus(todoId, statusId);
                    CustomConsole.Success("Todo status has been changed!");
                }
                else
                {
                    CustomConsole.Error($"Incorrect ids value");
                }
            }
            else
            {
                CustomConsole.Error("Incorrect value!");
            }
        }

        public void Remove()
        {
            Console.WriteLine("To do id to remove: ");
            if(int.TryParse(Console.ReadLine(), out int id) &&
                _todosRepository.GetById(id) != null)
            {
                _todosRepository.Remove(id);
                CustomConsole.Success("To do has been removed!");
            }
            else
            {
                CustomConsole.Error("Incorrect todo id!");  
            }
        }
    }
}
