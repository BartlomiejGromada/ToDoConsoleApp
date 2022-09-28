using ToDoConsoleApp.Seed;
using ToDoConsoleApp.Services;

CategorySeed.SeedData();
StatusSeed.SeedData();
ToDoSeed.SeedData();

var todosService = new ToDosService();

var running = true;
while(running)
{
    Console.WriteLine("*************");
    Console.WriteLine("A. Print All ToDos");
    Console.WriteLine("2. Add todo");
    Console.WriteLine("3. Remove todo");
    Console.WriteLine("Q. Exit");
    Console.WriteLine("*************");

    var choice = Console.ReadKey();
    Console.WriteLine();
    switch (choice.Key)
    {
        case ConsoleKey.A:
            todosService.GetAll();
            break;
        case ConsoleKey.Escape:
            running = false; 
            break;

        default:
            Console.WriteLine("Incorrect selection!");
            break;
    }
}


