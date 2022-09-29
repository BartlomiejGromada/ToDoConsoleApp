using ToDoConsoleApp.Entities;
using ToDoConsoleApp.Repositories;

namespace ToDoConsoleApp.Services
{
    public class CategoriesService : ICategoriesService
    {
        private readonly ICategoriesRepository _categoriesRepository;

        public CategoriesService()
        {
            _categoriesRepository = new CategoriesRepository();
        }
        public List<Category> GetAll()
        {
            return _categoriesRepository.GetAll()
                .ToList();
        }
    }
}
