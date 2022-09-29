using ToDoConsoleApp.Entities;

namespace ToDoConsoleApp.Repositories
{
    public class CategoriesRepository : ICategoriesRepository
    {
        public IEnumerable<Category> GetAll()
        {
            using var context = new ToDoDbContext();
            return context.Categories.ToList();
        }
    }
}
