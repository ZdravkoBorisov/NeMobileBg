﻿
namespace NeMobileBg.Data.Repository;

public interface IRepository
{
    Task<T> GetByIdAsync<T>(string id) where T : class;

    Task<IEnumerable<T>> GetAllAsync<T>() where T : class;

    Task AddAsync<T>(T entity) where T : class;

    Task UpdateAsync<T>(T entity) where T : class;

    Task RemoveAsync<T>(T entity) where T : class;

    Task<IEnumerable<T>> GetLastCreatedAsync<T>(Expression<Func<T, object>> orderProperty, int count) where T : class;

    Task SaveChangesAsync();
}
