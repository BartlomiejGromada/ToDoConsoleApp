using ToDoConsoleApp.Entities;

namespace ToDoConsoleApp.Services
{
    public interface ICategoriesService
    {
        List<Category> GetAll();
    }
}
