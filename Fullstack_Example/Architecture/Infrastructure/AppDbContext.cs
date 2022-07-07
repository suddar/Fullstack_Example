using Fullstack_Example.Architecture.Domain.Entities.Authentication;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Fullstack_Example.Architecture.Infrastructure
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Course> Courses { get; init; }
        public DbSet<Enrollment> Enrollments { get; init; }
        public DbSet<Learner> Learners { get; init; }
        public DbSet<Skill> Skills { get; init; }
        public DbSet<Teacher> Teachers { get; init; }
        public DbSet<Topic> Topics { get; init; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            }

            var allEntities = builder.Model.GetEntityTypes();
            foreach (var entity in allEntities)
            {
                entity.AddProperty("Created", typeof(DateTime));
                entity.AddProperty("CreatedBy", typeof(DateTime));
                entity.AddProperty("LastModified", typeof(DateTime));
                entity.AddProperty("LastModifiedBy", typeof(DateTime));
            }
        }

        public override int SaveChanges()
        {
            var res = base.SaveChanges();
            DisplayStates(ChangeTracker.Entries());
            return res;
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var res = base.SaveChangesAsync(cancellationToken);
            DisplayStates(ChangeTracker.Entries());
            return res;
        }

        private void DisplayStates(IEnumerable<EntityEntry> entries)
        {
            foreach (var entry in entries)
            {
                Console.WriteLine($"Entity: {entry.Entity.GetType().Name}, State: {entry.State.ToString()}");
            }
        }
    }
}
