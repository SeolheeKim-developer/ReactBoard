using Dul.Articles;
using Dul.Domain.Common;

namespace EntryApp.Models
{
    public interface IEntryRepository : IRepositoryBase<Entry, long, long>
    {
        // Install-Package Dul

        //Task<PagingResult<Entry>> GetAllAsync(int pageIndex, int pageSize); // paging
        Task<ArticleSet<Entry, long>> GetByAsync<TParentIdentifier>(FilterOptions<TParentIdentifier> options);
    }
}
