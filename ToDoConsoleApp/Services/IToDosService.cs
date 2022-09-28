using ToDoConsoleApp.Entities;

namespace ToDoConsoleApp.Services
{
    public interface IToDosService
    {
        void GetAll();
        void Add(ToDo toDo);
        void Remove(int id);
    }
}
