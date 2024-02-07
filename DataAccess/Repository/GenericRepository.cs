using Core.Entities;
using DataAccess.Abstract;
using DataAccess.Concrate;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Repository;

public class GenericRepository<TEntity, TContext> : IGenericDal<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
{
    protected Context c = new Context();
    public void Add(TEntity entity)
    {
        using (TContext context = new TContext())
        {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }
    }

    public void Delete(TEntity t)
    {
        using (TContext context = new TContext())
        {

            var contextAdded = context.Entry(t);
            contextAdded.State = EntityState.Deleted;
            context.SaveChanges();
        }
    }

    public List<TEntity> GetAllFilter(Expression<Func<TEntity, bool>> filter)
    {
        using (TContext context = new TContext())
        {

            return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
        }
    }

    public List<TEntity> GetAll()
    {
       
        return c.Set<TEntity>().ToList();
    }

    public TEntity GetById(int id)
    {
        
        return c.Set<TEntity>().Find(id);
    }

    public List<TEntity> GetList()
    {
        using var c = new Context();
        return c.Set<TEntity>().ToList();
    }

  
    public void Update(TEntity t)
    {
        using (TContext context = new TContext())
        {

            var contextAdded = context.Entry(t);
            contextAdded.State = EntityState.Modified;
            context.SaveChanges();
        }
    }

    
}
