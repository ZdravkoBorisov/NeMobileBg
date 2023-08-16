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
        try
        {
            await _dbContext.Set<T>().AddAsync(entity);
        }
        catch (Exception ex)
        {
            //send alert
            throw;
        }
    }

    public async Task<IEnumerable<T>> GetAllAsync<T>()
        where T : class
    {
        try
        {
            return await _dbContext.Set<T>().ToListAsync();
        }
        catch (Exception ex)
        {
            //send alert
            throw;
        }
    }

    public async Task RemoveAsync<T>(T entity)
        where T : class
    {
        try
        {

            await Task.Run(() => _dbContext.Set<T>().Remove(entity));
        }
        catch (Exception ex)
        {
            //send alerty
            throw;
        }
    }

    public async Task SaveChangesAsync()
    {
        try
        {
            await _dbContext.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            //send alert
            throw;
        }
    }

    public async Task UpdateAsync<T>(T entity) where T : class
    {
        try
        {

            await Task.Run(() => _dbContext.Set<T>().Update(entity));
        }
        catch (Exception ex)
        {
            //send alert
            throw;
        }
    }

    public async Task<T> GetByIdAsync<T>(string id) where T : class
    {
        try
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }
        catch (Exception ex)
        {
            //send alert
            throw;
        }
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
            //send alert
            throw;
        }

    }
}
