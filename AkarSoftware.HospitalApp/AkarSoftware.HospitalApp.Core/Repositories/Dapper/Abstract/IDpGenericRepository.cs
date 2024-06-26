﻿using AkarSoftware.HospitalApp.Core.Entities.Abstract;

namespace AkarSoftware.HospitalApp.Core.Repositories.Dapper.Abstract
{
    public interface IDpGenericRepository<T> where T : class, IEntity, new()
    {
        Task<T> GetAsync(Func<T, bool> where = null);
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetListAsync(Func<T, bool> where = null);
        Task AddAsync(T item);
        Task UpdateAsync(T item);
        Task DeleteAsync(T item);
        Task SoftDeleteAsync(T item);
    }
}
