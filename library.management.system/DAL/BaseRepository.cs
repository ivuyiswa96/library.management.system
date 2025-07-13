

using library.management.system.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace library.management.system.DAL
{
    public class BaseRepository :  IBaseRepository 
    {
        private DataContext _context;

        public BaseRepository(DataContext context)
        {
            _context = context;
        }

        public async Task AddEntityAsync<T>(T entity) where T : class
        {
            _context.Set<T>().Add(entity);
            SaveAsync();


        }

        public async Task DeleteEntityAsync<T>(T entity) where T : class
        {
          

            _context.Entry(entity).State = EntityState.Deleted;
            SaveAsync();

        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public IQueryable<T> Query<T>() where T : class
        {
            return _context.Set<T>().AsQueryable();
        }

        public async Task<IEnumerable<T>> SearchAsync<T>( Expression<Func<T, bool>>? predicate = null,params Expression<Func<T, object>>[] includeProperties) where T : class
        {
            var query = Query<T>();

            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            return await query.ToListAsync();
        }

    }

}
