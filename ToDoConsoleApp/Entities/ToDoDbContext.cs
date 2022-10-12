using Microsoft.EntityFrameworkCore;

namespace ToDoConsoleApp.Entities
{
    public class ToDoDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "ToDo");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }

        public DbSet<Status> Statuses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ToDo> ToDos { get; set; }
    }
}
