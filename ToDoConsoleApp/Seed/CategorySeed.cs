using ToDoConsoleApp.Entities;

namespace ToDoConsoleApp.Seed
{
    public static class CategorySeed
    {
        public static void SeedData()
        {
            using var context = new ToDoDbContext();
            if(!context.Categories.ToList().Any())
            {
                context.Categories.AddRange(
                        new Category("Work"),
                        new Category("House"),
                        new Category("Sport"),
                        new Category("Shopping"),
                        new Category("Others")
                    );
                context.SaveChanges();
            }
        }
    }
}
