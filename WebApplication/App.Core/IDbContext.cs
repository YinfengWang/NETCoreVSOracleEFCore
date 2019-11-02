using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace App.Core
{
    public interface IDbContext
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity;
        EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : BaseEntity;
        int SaveChanges();
    }
}
