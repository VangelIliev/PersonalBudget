using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PersonalBudgetDb.DbContext;
using PersonalBudgetServices.Interfaces;
using PersonalBudgetServices.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetServices.Implementation
{
    public abstract class ServiceBase<T> : IServiceBase<T> where T : class, IBaseEntity
    {
        protected readonly PersonalBudgetDbContext _dbContext;
        private readonly ILogger _logger;

        public ServiceBase(PersonalBudgetDbContext dbContext, ILogger logger)
        {
            this._dbContext = dbContext;
            this._logger = logger;
        }

        public async Task<bool> CreateAsync(T entity)
        {
            try
            {
                this._dbContext.Set<T>().Add(entity);
                await this._dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                throw;
            }
        }

        public async Task DeleteAsync(T entity)
        {
            try
            {
                this._dbContext.Set<T>().Remove(entity);
                await this._dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                throw;
            }
            
        }

        public virtual async Task DeleteAsync(Guid id)
        {
            try
            {
                var entity = await this._dbContext.Set<T>()
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

                this._dbContext.Set<T>().Remove(entity);
                await this._dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                throw;
            }
            
        }

        public async Task<List<T>> FindAllAsync()
        {
            try
            {
                return await this._dbContext.Set<T>().AsNoTracking().ToListAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                throw;
            }
            
        }

        public async Task<T> ReadAsync(Guid id)
        {
            try
            {
                return await this._dbContext.Set<T>()
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                throw;
            }
            
        }

        public async Task UpdateAsync(T entity)
        {
            try
            {
                this._dbContext.Set<T>().Update(entity);
                await this._dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                throw;
            }
           
        }
    }
}
