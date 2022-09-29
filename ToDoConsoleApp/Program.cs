using ToDoConsoleApp.Entities;
using ToDoConsoleApp.Seed;
using ToDoConsoleApp.Services;

CategorySeed.SeedData();
StatusSeed.SeedData();
ToDoSeed.SeedData();

var todosService = new ToDosService();
var categoriesService = new CategoriesService();
List<Category> categories = null;

var running = true;
while(running)
{
    Console.WriteLine("*************");
    Console.WriteLine("P. Print All ToDos");
    Console.WriteLine("A. Add todo");
    Console.WriteLine("R. Remove todo");
    Console.WriteLine("C. Clear console");
    Console.WriteLine("Q. Exit");
    Console.WriteLine("*************");

    var choice = Console.ReadKey();
    Console.WriteLine();
    switch (choice.Key)
    {
        case ConsoleKey.P:
            todosService.GetAll();
            break;
        case ConsoleKey.A:
            categories ??= categoriesService.GetAll();
            todosService.Add(categories);
            break;
        case ConsoleKey.R:
            todosService.Remove();
            break;
        case ConsoleKey.C:
            Console.Clear();
            break;
        case ConsoleKey.Q:
            running = false; 
            break;

        default:
            Console.WriteLine("Incorrect selection!");
            break;
    }
}


