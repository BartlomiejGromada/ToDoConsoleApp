using ToDoConsoleApp.Entities;

namespace ToDoConsoleApp.Services
{
    public interface IToDosService
    {
        void GetAll();
        void Add(List<Category> categories);
        void Remove();
    }
}
