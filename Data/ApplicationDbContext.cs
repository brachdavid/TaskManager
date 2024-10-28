using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaskManager.Models;

namespace TaskManager.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<TeamMember>(options)
    {
        // DbSet properties for Client and TaskItem
        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<TaskItem> TaskItems { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Configure one-to-many relationship between Client and TaskItem with cascade delete
            builder.Entity<Client>()
                   .HasMany(c => c.Tasks)
                   .WithOne(t => t.Client)
                   .HasForeignKey(t => t.ClientId)
                   .OnDelete(DeleteBehavior.Cascade);

            // Configure one-to-many relationship between Client and ProjectManager with set null delete
            builder.Entity<Client>()
                   .HasOne(c => c.ProjectManager)
                   .WithMany(tm => tm.ManagedClients)
                   .HasForeignKey(c => c.ProjectManagerId)
                   .OnDelete(DeleteBehavior.SetNull);

            // Configure many-to-one relationship between TaskItem and TeamMember with set null delete
            builder.Entity<TaskItem>()
                   .HasOne(t => t.TeamMember)
                   .WithMany(tm => tm.Tasks)
                   .HasForeignKey(t => t.TeamMemberId)
                   .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
