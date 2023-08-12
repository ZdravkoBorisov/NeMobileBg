using System.Linq.Expressions;

namespace NeMobileBg.Data.Repository;

public interface IRepository
{
    Task<T> GetByIdAsync<T>(string id) where T : class;

    Task<IEnumerable<T>> GetAllAsync<T>() where T : class;

    Task<IEnumerable<T>> GetAllAsync<T>(Expression<Func<T, bool>> predicate) where T : class;

    Task AddAsync<T>(T entity) where T : class;

    Task UpdateAsync<T>(T entity) where T : class;

    Task RemoveAsync<T>(T entity) where T : class;

    Task<T> FindAsync<T>(Expression<Func<T, bool>> predicate) where T : class;

    Task<bool> AnyAsync<T>(Expression<Func<T, bool>> predicate) where T : class;

    Task<T> FirstOrDefaultAsync<T>(Expression<Func<T, bool>> predicate) where T : class;

    Task SaveChangesAsync();
}
