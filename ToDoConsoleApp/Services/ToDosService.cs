using ToDoConsoleApp.Entities;
using ToDoConsoleApp.Repositories;

namespace ToDoConsoleApp.Services
{
    public class ToDosService : IToDosService
    {
        private readonly IToDosRepository _todosRepository;
        public ToDosService()
        {
            _todosRepository = new ToDosRepository();
        }
        public void Add(ToDo toDo)
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
           var todos = _todosRepository.GetAll();
           todos.ForEach(todo => Console.WriteLine(todo));
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
