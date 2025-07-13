using library.management.system.Models;

namespace library.management.system.Interfaces
{
    public interface IBookService
    {
        Task AddAsync(Book book );
        Task DeleteAsync( Book book );
        Task<IEnumerable<Book>> SearchAsync( string title );

    }
}
