using AppCore.Records.Bases;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AppCore.DataAccess.EntityFramework.Bases
{
    public abstract class RepositoryPattern<TEntity> : IDisposable where TEntity : RecordBase, new()
    {
        protected readonly DbContext _dbContext;

        protected RepositoryPattern(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual IQueryable<TEntity> Query(params Expression<Func<TEntity, object>>[] entitiesToInclude)
        {
            var query = _dbContext.Set<TEntity>().AsQueryable();
            foreach (var entityToInclude in entitiesToInclude)
            {
                query = query.Include(entityToInclude);
            }
            return query;
        }

        public virtual IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] entitiesToInclude)
        {
            var query = Query(entitiesToInclude);
            return query.Where(predicate);
        }

        public virtual IQueryable<TRelationalEntity> Query<TRelationalEntity>() where TRelationalEntity : class, new()
        {
            return _dbContext.Set<TRelationalEntity>().AsQueryable();
        }

        public virtual bool Exists(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] entitiesToInclude)
        {
            return Query(entitiesToInclude).Any(predicate);
        }

        public virtual void Add(TEntity entity, bool save = true)
        {
            entity.Guid = Guid.NewGuid().ToString();
            _dbContext.Add(entity);

            if (save)
                Save();
        }

        public virtual void Update(TEntity entity, bool save = true)
        {
            _dbContext.Update(entity);

            if (save)
                Save();
        }

        public virtual void Delete(TEntity entity, bool save = true)
        {
            _dbContext.Remove(entity);

            if (save)
                Save();
        }

        public virtual void Delete(int id, bool save = true)
        {
            var entity = _dbContext.Set<TEntity>().Find(id);
            Delete(entity, save);
        }

        public virtual void Delete(Expression<Func<TEntity, bool>> predicate, bool save = true)
        {
            var entities = _dbContext.Set<TEntity>().Where(predicate).ToList();

            foreach (var entity in entities)
            {
                Delete(entity, false);
            }
            if (save)
                Save();
        }

        public virtual void Delete<TRelationalEntity>(Expression<Func<TRelationalEntity, bool>> predicate, bool save = false) where TRelationalEntity : class, new()
        {
            var relationalEntities = Query<TRelationalEntity>().Where(predicate).ToList();
            _dbContext.Set<TRelationalEntity>().RemoveRange(relationalEntities);
            if (save)
                Save();
        }

        public virtual int Save()
        {
            try
            {
                return _dbContext.SaveChanges();
            }
            catch (Exception exc)
            {


                throw exc;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
