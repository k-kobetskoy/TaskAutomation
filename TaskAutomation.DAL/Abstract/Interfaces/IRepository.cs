namespace TaskAutomation.DAL.Abstract.Interfaces;

public interface IRepository<TEntity>
{
    IQueryable<TEntity> FindAll();

    Task<TEntity?> GetByIdAsync(int id);

    Task AddAsync(TEntity entity);

    void Update(TEntity entity);

    void Delete(TEntity entity);

    Task DeleteByIdAsync(int id);
}