using KitobNur.Domain.Comon;
using LocationTracker.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using SizeAdvisor.Data.DbContexts;

namespace LocationTracker.Data.Repositories;

public class Repository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : Auditable<TKey>
{
    protected readonly AppDbContext _dbContext;
    protected readonly DbSet<TEntity> _dbSet;

    public Repository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<TEntity>();
    }

    public async Task<TEntity> InsertAsync(TEntity entity)
    {
        var entry = await _dbSet.AddAsync(entity);

        await _dbContext.SaveChangesAsync();

        return entry.Entity;
    }

    public async Task<bool> DeleteAsync(TKey id)
    {
        var entity = await _dbSet.FirstOrDefaultAsync(e => e.Id.Equals(id));
        _dbSet.Remove(entity);

        return await _dbContext.SaveChangesAsync() > 0;
    }

    public IQueryable<TEntity> SelectAll()
        => _dbSet;

    public async Task<TEntity> SelectByIdAsync(TKey id)
        => await _dbSet.FirstOrDefaultAsync(e => e.Id.Equals(id));

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        try
        {
            var entry = _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync();
            return entry.Entity;

        }
        catch (Exception ex)
        {
            await Console.Out.WriteLineAsync(ex.Message);

        }
        throw new NotImplementedException();


    }

    public async Task SaveAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}
