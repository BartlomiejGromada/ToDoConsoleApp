using ToDoConsoleApp.Entities;

namespace ToDoConsoleApp.Seed
{
    public static class StatusSeed
    {
        public static void SeedData()
        {
            using var context = new ToDoDbContext();
            if(!context.Statuses.ToList().Any())
            {
                context.Statuses.AddRange(
                        new Status("Introduced"),
                        new Status("In progress"),
                        new Status("Cancelled"),
                        new Status("Done")
                    );
                context.SaveChanges();
            }
        }
    }
}
