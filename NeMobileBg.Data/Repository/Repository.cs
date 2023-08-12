using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace NeMobileBg.Data.Repository;

public class Repository : IRepository
{
    private readonly ApplicationDbContext _dbContext;

    public Repository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddAsync<T>(T entity) where T : class
    {
        await _dbContext.Set<T>().AddAsync(entity);
    }

    public async Task<T> FindAsync<T>(Expression<Func<T, bool>> predicate)
        where T : class
    {
        return await _dbContext.Set<T>().FirstOrDefaultAsync(predicate);
    }

    public async Task<IEnumerable<T>> GetAllAsync<T>() 
        where T : class
    {
        return await _dbContext.Set<T>().ToListAsync();
    }

    public async Task<IEnumerable<T>> GetAllAsync<T>(Expression<Func<T, bool>> predicate) where T : class
    {
        return await _dbContext.Set<T>()
                                  .Where(predicate)
                                    .ToListAsync();
    }

    public async Task RemoveAsync<T>(T entity) 
        where T : class
    {
        await Task.Run(() => _dbContext.Set<T>().Remove(entity));
    }

    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync<T>(T entity) where T : class
    {
        await Task.Run(() => _dbContext.Set<T>().Update(entity));
    }

    public async Task<bool> AnyAsync<T>(Expression<Func<T, bool>> predicate) where T : class
    {
        return await _dbContext.Set<T>().AnyAsync(predicate);
    }


    public async Task<T> FirstOrDefaultAsync<T>(Expression<Func<T, bool>> predicate) where T : class
    {
        return await _dbContext.Set<T>().FirstOrDefaultAsync(predicate);
    }

    public async Task<T> GetByIdAsync<T>(string id) where T : class
    {
        return await _dbContext.Set<T>().FindAsync(id);
    }

    public async Task<IEnumerable<T>> GetLastCreatedAsync<T>(Expression<Func<T, object>> orderProperty, int count) where T : class
    {
        try
        {
            return await _dbContext.Set<T>()
                              .OrderByDescending(orderProperty)
                                  .Take(count)
                                      .ToListAsync();
        }
        catch (Exception ex)
        {
            //todo
            return new List<T>();
        }
       
    }
}
