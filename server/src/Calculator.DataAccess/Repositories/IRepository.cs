using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Calculator.DataAccess.Entities;

namespace Calculator.DataAccess.Repositories
{
    public interface IRepository<T> where T : class, IEntity
    {
        T GetById(string id);

        IEnumerable<T> Get(Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");

        IEnumerable<T> GetAll();
        void Insert(T entity);
        void Delete(T entity);
    }

    public interface IRepository
    {
        object GetById(string id);
        IEnumerable GetAll();
        void Insert(object entity);
        void Delete(object entity);
    }
}