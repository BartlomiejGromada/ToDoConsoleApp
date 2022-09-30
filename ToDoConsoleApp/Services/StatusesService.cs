using ToDoConsoleApp.Entities;

namespace ToDoConsoleApp.Services
{
    public class StatusesService : IStatusesService
    {
        public List<Status> GetAll()
        {
            using var context = new ToDoDbContext();
            return context.Statuses
                .ToList();
;        }
    }
}
