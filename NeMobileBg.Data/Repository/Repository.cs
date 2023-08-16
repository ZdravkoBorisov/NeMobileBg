using NeMobileBg.Services.Contracts;

namespace NeMobileBg.Data.Repository;

public class Repository : IRepository
{
    private readonly ApplicationDbContext _dbContext;
    private readonly IAlertsService _alertsService;

    public Repository(ApplicationDbContext dbContext,
                      IAlertsService alertsService)
    {
        _dbContext = dbContext;
        this._alertsService = alertsService;
    }

    public async Task AddAsync<T>(T entity) where T : class
    {
        try
        {
            await _dbContext.Set<T>().AddAsync(entity);
            this._alertsService.SendAlert(new ArgumentNullException("test alert service"), "ALERT! Error while adding entity to db");
        }
        catch (Exception ex)
        {
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
            this._alertsService.SendAlert(ex, "ALERT! Error while getting all entities from db");
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
            this._alertsService.SendAlert(ex, "Error while removing entity from db");
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
            this._alertsService.SendAlert(ex, "Error while saving changes to db");
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
            this._alertsService.SendAlert(ex, "Error while updating entity in db");
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
            this._alertsService.SendAlert(ex, "Error while getting entity by id from db");
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
            this._alertsService.SendAlert(ex, "Error while getting last created entities from db");
            throw;
        }

    }
}
