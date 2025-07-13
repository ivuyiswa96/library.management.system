
namespace library.management.system.Interfaces
{
    public interface IBaseRepository
    {
    

        Task<IEnumerable<T>> SearchAsync<T>(System.Linq.Expressions.Expression<Func<T, bool>> predicate, params System.Linq.Expressions.Expression<Func<T, object>>[] includeProperties) where T : class;
     
        Task AddEntityAsync<T>(T entity) where T : class;

        Task DeleteEntityAsync<T>(T entity) where T : class;

        IQueryable<T> Query<T>() where T : class;

        Task SaveAsync();

    }
}
