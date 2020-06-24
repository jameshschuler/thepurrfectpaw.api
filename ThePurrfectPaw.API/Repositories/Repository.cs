using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ThePurrfectPaw.API.Entities;

namespace ThePurrfectPaw.API.Services
{
    public abstract class Repository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class, IEntity
        where TContext: DbContext
    {
        private readonly TContext context;

        public Repository(TContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<TEntity> Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Task<int> CountAll() => context.Set<TEntity>().CountAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public Task<int> CountWhere(Expression<Func<TEntity, bool>> predicate)
            => context.Set<TEntity>().CountAsync(predicate);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<TEntity> Delete(int id)
        {
            var entity = await context.Set<TEntity>().FindAsync(id);
            if (entity == null)
            {
                return entity;
            }

            context.Set<TEntity>().Remove(entity);
            await context.SaveChangesAsync();

            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        public Task<TEntity> FirstOrDefault(Expression<Func<TEntity, bool>> predicate, string includeProperties)
        {
            if (!string.IsNullOrWhiteSpace(includeProperties))
            {
                return context.Set<TEntity>().Include(includeProperties).FirstOrDefaultAsync(predicate);
            }

            return context.Set<TEntity>().FirstOrDefaultAsync(predicate);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<TEntity> Get(int id)
        {
            return await context.Set<TEntity>().FindAsync(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        public async Task<List<TEntity>> GetAll(string includeProperties)
        {
            var query = context.Set<TEntity>().AsQueryable();
            
            if ( !string.IsNullOrWhiteSpace( includeProperties ) )
            {
                foreach ( var include in includeProperties.Split( "," ) )
                {
                    query = query.Include( include );
                }
            }

            return await query.ToListAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<TEntity> GetById( int id ) => await context.Set<TEntity>().FindAsync( id );


        /// <summary>
        /// 
        /// </summary>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        public IQueryable<TEntity> GetWhere( string includeProperties )
        {
            var query = context.Set<TEntity>().AsQueryable();

            if ( !string.IsNullOrWhiteSpace( includeProperties ) )
            {
                foreach ( var include in includeProperties.Split( "," ) )
                {
                    query = query.Include( include );
                }
            }

            return query;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        public async Task<IEnumerable<TEntity>> GetWhere(Expression<Func<TEntity, bool>> predicate, string includeProperties)
        {
            var query = context.Set<TEntity>().AsQueryable();

            if ( !string.IsNullOrWhiteSpace( includeProperties ) )
            {
                foreach ( var include in includeProperties.Split( "," ) )
                {
                    query = query.Include( include );
                }
            }

            return await query.Where( predicate ).ToListAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<TEntity> Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return entity;
        }
    }
}
