using IndividualProject.Domain.Entities;
using IndividualProject.Infrastructure.Data;
using IndividualProject.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace IndividualProject.Infrastructure.Repositories
{
    public abstract class GenericRepository<TEntity> : IRepository<TEntity>
        where TEntity : BaseEntity
    {
        protected readonly IndividualProjectDbContext context;
        protected readonly DbSet<TEntity> dbSet;

        public GenericRepository(IndividualProjectDbContext context)
        {
            this.context = context;
            dbSet = context.Set<TEntity>();
        }

        public async Task AddAsync(TEntity entity)
        {
            await dbSet.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(TEntity entity)
        {
            this.dbSet.Remove(entity);
            await Task.CompletedTask;
        }

        public virtual async Task<IEnumerable<TResult>> GetAllAsync<TResult>(Expression<Func<TEntity, TResult>> selector,
            Func<IQueryable<TEntity>, IQueryable<TEntity>> include = null)
        {
            var result = Include(include).Select(selector).ToList();

            return await Task.FromResult(result);
        }

        public virtual async Task<IQueryable<TEntity>> GetAllAsync(Func<IQueryable<TEntity>, IQueryable<TEntity>> include = null)
        {
            var result = Include(include);

            return await Task.FromResult(result);
        }

        public virtual async Task<TEntity> GetAsync(int id, Func<IQueryable<TEntity>, IQueryable<TEntity>> include = null)
        {
            var entity = await Include(include).Where(x => x.Id == id).FirstOrDefaultAsync().ConfigureAwait(false);

            if (entity != null)
            {
                this.context.Entry(entity).State = EntityState.Detached;

                return entity;
            }

            return null;
        }

        //public virtual async Task<TResult> GetAsync<TResult>(int id, Expression<Func<TEntity, TResult>> selector,
        //    Func<IQueryable<TEntity>, IQueryable<TEntity>> include = null)
        //{
        //    var entity = await Include(include)
        //        .Where(x => x.Id == id)
        //        .Select(selector)
        //        .FirstOrDefaultAsync()
        //        .ConfigureAwait(false);

        //    return entity;
        //}

        public virtual async Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> match,
            Func<IQueryable<TEntity>, IQueryable<TEntity>> include = null)
        {
            var result = await Include(include)
                .Where(match)
                .FirstOrDefaultAsync()
                .ConfigureAwait(false);

            return result;
        }

        public virtual async Task<TResult> FindAsync<TResult>(Expression<Func<TEntity, TResult>> selector,
            Expression<Func<TEntity, bool>> match,
            Func<IQueryable<TEntity>, IQueryable<TEntity>> include = null)
        {
            var result = Include(include)
                .Where(match)
                .Select(selector)
                .FirstOrDefault();

            return await Task.FromResult(result);
        }

        public virtual void Update(TEntity entity)
        {
            entity = entity ?? throw new ArgumentNullException(nameof(entity));

            this.context.Entry(entity).State = EntityState.Modified;
        }

        public virtual int Save()
        {
            return this.context.SaveChanges();
        }

        public virtual async Task<int> SaveAsync()
        {
            return await this.context.SaveChangesAsync().ConfigureAwait(false);
        }

        public virtual IQueryable<TEntity> Include(Func<IQueryable<TEntity>, IQueryable<TEntity>> expression)
        {
            IQueryable<TEntity> queryable = this.dbSet.AsNoTracking();

            if (expression != null)
            {
                queryable = expression(queryable);
            }

            return queryable;
        }
    }
}
