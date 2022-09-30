using ToDoConsoleApp.Entities;

namespace ToDoConsoleApp.Repositories
{
    public interface IToDosRepository
    {
        int Count();
        List<ToDo> GetAll();
        ToDo GetById(int id);
        void Add(ToDo toDo);
        void ChangeStatus(int toDoId, int statusId);
        void Remove(int id);
    }
}
