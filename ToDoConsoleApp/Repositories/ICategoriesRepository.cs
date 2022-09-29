using ToDoConsoleApp.Entities;

namespace ToDoConsoleApp.Repositories
{
    public interface ICategoriesRepository
    {
        IEnumerable<Category> GetAll();

    }
}
