using ToDoConsoleApp.Entities;

namespace ToDoConsoleApp.Repositories
{
    public interface IToDosRepository
    {
        int Count();
        List<ToDo> GetAll();
        void Add(ToDo toDo);
        void Remove(int id);
    }
}
