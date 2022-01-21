using PersonalBudgetServices.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetServices.Interfaces
{
    public interface IServiceBase<T> where T : IBaseEntity
    {
        Task<List<T>> FindAllAsync();

        Task<bool> CreateAsync(T entity);

        Task<T> ReadAsync(Guid id);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        Task DeleteAsync(Guid id);
    }
}
