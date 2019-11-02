using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Core
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(string id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> Table { get; }
        IDbContext GetDbContext();
    }
}
