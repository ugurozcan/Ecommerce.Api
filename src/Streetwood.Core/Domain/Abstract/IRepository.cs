using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Streetwood.Core.Dto;

namespace Streetwood.Core.Domain.Abstract
{
    public interface IRepository<T> where T : Entity
    {
        Task<GenericListWithPagingResponseModel<T>> GetListAsync(GenericListWithPagingRequestModel req);

        IQueryable<T> GetQueryable();

        Task<T> GetAsync(Guid id);

        Task<IList<T>> GetByIdsAsync(IEnumerable<Guid> ids);

        Task<T> GetAndEnsureExistAsync(Guid id);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        Task SaveChangesAsync();
    }
}
