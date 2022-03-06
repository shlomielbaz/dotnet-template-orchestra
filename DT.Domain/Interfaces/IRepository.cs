using DT.Domain.Entities;
using DT.Domain.Enums;
using DT.Domain.General;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DT.Domain.Interfaces
{
    public interface IRepository<C> where C : DbContext
    {
        public void Add<T>(T entity) where T : class;
        public bool Any<T>(Expression<Func<T, bool>> predicate) where T : class;
        public int Count<T>(Expression<Func<T, bool>> predicate) where T : class;
        public T Get<T>(Expression<Func<T, bool>> predicate) where T : class;
        public IQueryable<T> GetList<T>(Expression<Func<T, bool>> predicate) where T : class;
        public IQueryable<T> GetList<T, TKey>(Expression<Func<T, bool>> predicate, Expression<Func<T, TKey>> orderBy) where T : class;
        public IQueryable<T> GetList<T, TKey>(Expression<Func<T, bool>> predicate, OrderByType orderByType, Expression<Func<T, TKey>> orderBy) where T : class;
        public IQueryable<T> GetList<T, TKey>(Expression<Func<T, TKey>> orderBy) where T : class;
        public IQueryable<T> GetList<T, TKey>(OrderByType orderByType, Expression<Func<T, TKey>> orderBy) where T : class;
        public IQueryable<T> GetList<T>() where T : class;
        public void Update<T>(T entity) where T : IEntity;
        public void Delete<T>(T entity) where T : class;
        public Task DeleteAsync<T>(T entity) where T : class;
        public void DeleteAll<T>(ICollection<T> collection) where T : class;
        public Task DeleteAllAsync<T>(ICollection<T> collection) where T : class;
        public OperationStatus Save(string message);
        public OperationStatus SaveAync(string message);
    }
}
