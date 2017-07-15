using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Calculator.DataAccess.Entities;

namespace Calculator.DataAccess.Repositories
{
    public class RepositoryBase<T> : IRepository<T>, IRepository where T : class, IEntity
    {
        protected static readonly List<T> DbSet = new List<T>();

        object IRepository.GetById(string id)
        {
            return GetById(id);
        }

        IEnumerable IRepository.GetAll()
        {
            return GetAll();
        }

        public void Insert(object entity)
        {
            Insert((T) entity);
        }

        public void Delete(object entity)
        {
            Delete((T) entity);
        }

        public virtual IEnumerable<T> Get(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<T> query = DbSet.AsQueryable<T>();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return orderBy?.Invoke(query).ToList() ?? query.ToList();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return DbSet.AsEnumerable();
        }

        public virtual T GetById(string id)
        {
            return DbSet.Find(x => x.Id == id);
        }

        public virtual void Insert(T entity)
        {
            DbSet.Add(entity);
        }

        public virtual void Delete(T entityToDelete)
        {
            DbSet.Remove(entityToDelete);
        }
    }
}