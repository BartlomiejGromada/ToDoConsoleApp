using Microsoft.EntityFrameworkCore;
using ToDoConsoleApp.Entities;

namespace ToDoConsoleApp.Repositories
{
    public class ToDosRepository : IToDosRepository
    {
        public int Count()
        {
            using var context = new ToDoDbContext();
            return context.ToDos.Count();
        }
        public void Add(ToDo toDo)
        {
            using var context = new ToDoDbContext();
            foreach (var item in toDo.Categories)
            {
                context.Entry(item).State = EntityState.Unchanged;
            }
         
            context.ToDos.Add(toDo);
            context.SaveChanges();
        }

        public List<ToDo> GetAll()
        {
            using var context = new ToDoDbContext();
            return context.ToDos
                .Include(td => td.Categories)
                .Include(td => td.Status)
                .ToList();
        }

        public void Remove(int id)
        {
            using var context = new ToDoDbContext();
            var todo = context.ToDos
                .FirstOrDefault(td => td.Id == id);
            context.ToDos.Remove(todo);
            context.SaveChanges();
        }
    }
}
