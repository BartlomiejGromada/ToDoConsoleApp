using ToDoConsoleApp.Entities;

namespace ToDoConsoleApp.Seed
{
    public static class ToDoSeed
    {
        public static void SeedData()
        {
            {
                using var context = new ToDoDbContext();
                if (!context.ToDos.ToList().Any())
                {
                    var category = context.Categories
                        .FirstOrDefault(c => c.Name == "Work");

                    context.ToDos.Add(
                           new ToDo()
                           {
                               Name = "LEARNING UNIT TESTS",
                               DateFrom = DateTime.Now,
                               DateTo = DateTime.Now.AddDays(7),
                               Categories = { category },
                               Priority = 10,
                               StatusId = 1,
                               Command = "Udemy course",
                               CreatedAt = DateTime.Now,
                           }
                        );
                    context.SaveChanges();
                }
            }
        }
    }
}
