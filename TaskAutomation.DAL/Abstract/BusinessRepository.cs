using Microsoft.EntityFrameworkCore;
using TaskAutomation.DAL.Abstract.Interfaces;
using TaskAutomation.Domain.Abstract;

namespace TaskAutomation.DAL.Abstract;

public abstract class BusinessRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{
    private readonly TaskAutomationBusinessDbContext _context;

    protected BusinessRepository(TaskAutomationBusinessDbContext context) => _context = context;

    public virtual IQueryable<TEntity> FindAll() => _context.Set<TEntity>();

    public virtual async Task<TEntity?> GetByIdAsync(int id) => await _context.Set<TEntity>().FindAsync(id);

    public virtual async Task AddAsync(TEntity entity) => await _context.Set<TEntity>().AddAsync(entity);

    public virtual void Update(TEntity entity)
    {
        _context.Set<TEntity>().Attach(entity);
        _context.Entry(entity).State = EntityState.Modified;
    }

    public virtual void Delete(TEntity entity) => _context.Set<TEntity>().Remove(entity);

    public virtual async Task DeleteByIdAsync(int id)
    {
        var entity = await GetByIdAsync(id);
        
        if (entity != null)
            Delete(entity);
    }
}