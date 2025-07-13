using library.management.system.DAL;
using library.management.system.Interfaces;
using library.management.system.Models;

namespace library.management.system.Services
{
    public class BookService : IBookService
    {
        private readonly IBaseRepository _baseRepository;

        public BookService(IBaseRepository baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task AddAsync(Book book)
        {
            await _baseRepository.AddEntityAsync(book);
        }

        public async Task DeleteAsync(Book book)
        {
            await _baseRepository.DeleteEntityAsync(book);
        }

        public async Task<IEnumerable<Book>> SearchAsync(string searchParam)
        {
            return await _baseRepository.SearchAsync<Book>(
            b => b.Title.Contains(searchParam)
        );
        }
    }
}