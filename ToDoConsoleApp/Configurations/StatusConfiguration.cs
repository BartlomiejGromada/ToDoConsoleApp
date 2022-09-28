using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoConsoleApp.Entities;

namespace ToDoConsoleApp.Configurations
{
    public class StatusConfiguration : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.Property(s => s.Name)
                .HasMaxLength(150)
                .IsRequired();
        }
    }
}
