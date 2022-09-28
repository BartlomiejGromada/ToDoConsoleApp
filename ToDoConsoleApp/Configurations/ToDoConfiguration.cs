using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoConsoleApp.Entities;

namespace ToDoConsoleApp.Configurations
{
    public class ToDoConfiguration : IEntityTypeConfiguration<ToDo>
    {
        public void Configure(EntityTypeBuilder<ToDo> builder)
        {
            builder.Property(td => td.Name)
                .IsRequired();
            builder.HasOne(td => td.Status)
                .WithMany()
                .HasForeignKey(td => td.StatusId);
            builder.HasMany(td => td.Categories)
                .WithMany(c => c.ToDos);
        }
    }
}
