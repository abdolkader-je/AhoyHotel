using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected DatabaseContext databaseContext { get; set; }
        public BaseRepository(DatabaseContext repositoryContext)
        {
            databaseContext = repositoryContext;
        }

        public IQueryable<T> FindAll() => databaseContext.Set<T>().AsNoTracking();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression) =>
            databaseContext.Set<T>().Where(expression).AsNoTracking();

        public void Create(T entity) => databaseContext.Set<T>().Add(entity);

        public void Update(T entity) => databaseContext.Set<T>().Update(entity);

        public void Delete(T entity) => databaseContext.Set<T>().Remove(entity);
    }

}
