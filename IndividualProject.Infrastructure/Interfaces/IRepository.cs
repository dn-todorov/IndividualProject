using System.Linq.Expressions;

namespace IndividualProject.Infrastructure.Interfaces
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
        Task<TResult> GetAsync<TResult>(int id, Expression<Func<TEntity, TResult>> selector,
                    Func<IQueryable<TEntity>, IQueryable<TEntity>> include = null);
        Task<TEntity> GetAsync(int id, Func<IQueryable<TEntity>, IQueryable<TEntity>> include = null);
        Task<IEnumerable<TResult>> GetAllAsync<TResult>(Expression<Func<TEntity, TResult>> selector,
            Func<IQueryable<TEntity>, IQueryable<TEntity>> include = null);
        Task<IQueryable<TEntity>> GetAllAsync(Func<IQueryable<TEntity>, IQueryable<TEntity>> include = null);
        Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> match,
            Func<IQueryable<TEntity>, IQueryable<TEntity>> include = null);
        Task<TResult> FindAsync<TResult>(Expression<Func<TEntity, TResult>> selector,
            Expression<Func<TEntity, bool>> match,
            Func<IQueryable<TEntity>, IQueryable<TEntity>> include = null);
        Task AddAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
        int Save();
        Task<int> SaveAsync();
        void Update(TEntity entity);
        IQueryable<TEntity> Include(Func<IQueryable<TEntity>, IQueryable<TEntity>> expression);
    }
}
