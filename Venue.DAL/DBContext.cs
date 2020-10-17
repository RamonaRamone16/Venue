using EntityFrameworkCore.CommonTools;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Threading;
using System.Threading.Tasks;
using Venue.DAL.Entities;

namespace Venue.DAL
{
    public class DBContext : IdentityDbContext<User>
    {
        public DbSet<Place> Places { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

           // builder.ApplyConfigurationsFromAssembly(typeof(DBContext).Assembly);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            this.UpdateTrackableEntities();
            return await base.SaveChangesAsync(cancellationToken);
        }

        public async ValueTask<EntityEntry<TEntity>> AddAsync<TEntity>(TEntity entity) where TEntity : BaseEntity<int>
        {
            var entityEntry = await base.AddAsync(entity);
            await SaveChangesAsync();

            return entityEntry;
        }

        public async ValueTask<EntityEntry<TEntity>> RemoveAsync<TEntity>(TEntity entity) where TEntity : BaseEntity<int>
        {
            var entityEntry = base.Remove(entity);
            await SaveChangesAsync();

            return entityEntry;
        }

        public async ValueTask<EntityEntry<TEntity>> UpdateAsync<TEntity>(TEntity entity) where TEntity : BaseEntity<int>
        {
            var entityEntry = base.Update(entity);
            await SaveChangesAsync();

            return entityEntry;
        }
    }
}
