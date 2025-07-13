using library.management.system.Interfaces;
using library.management.system.Models;
using library.management.system.Services;

using Moq;
using System.Linq.Expressions;
using Xunit;

namespace library.management.system.Test
{
    public class BookServiceTests
    {
        [Fact]
        public async Task AddAsync_Should_Call_AddEntityAsync()
        {
            var mockRepo = new Mock<IBaseRepository>();
            var bookService = new BookService(mockRepo.Object);

            var book = new Book
            {
                Title = "LoveBook",
                Author = "Vusi Nkomo",
                ISBN = "9506035828082",
                PublicationYear = DateTime.Now
            };

            await bookService.AddAsync(book);

            mockRepo.Verify(r => r.AddEntityAsync(book), Times.Once);
        }

        [Fact]
        public async Task DeleteAsync_Should_Call_DeleteEntityAsync()
        {
            var mockRepo = new Mock<IBaseRepository>();
            var bookService = new BookService(mockRepo.Object);

            var book = new Book
            {
                Title = "Deleting Story",
                Author = "Mangethe Zwane",
                ISBN = "9506035838082",
                PublicationYear = DateTime.Now
            };

            await bookService.DeleteAsync(book);

            mockRepo.Verify(r => r.DeleteEntityAsync(book), Times.Once);
        }

        [Fact]
        public async Task SearchAsync_Should_Call_SearchAsync_And_Return_Results()
        {

         
            var mockRepo = new Mock<IBaseRepository>();
            var bookService = new BookService(mockRepo.Object);
            var searchParam = "Love";
            var expectedBooks = new List<Book>
             {
                new Book { Title = "Searching story", Author = "Author 1" },
                new Book { Title = "Love", Author = "Author 2" }
            };

            mockRepo.Setup(r => r.SearchAsync<Book>(It.IsAny<Expression<Func<Book, bool>>>()))
                .ReturnsAsync(expectedBooks);

            var result = await bookService.SearchAsync(searchParam);
            var resultList = result.ToList();
            Assert.Equal(2, resultList.Count);
            mockRepo.Verify(r => r.SearchAsync<Book>(It.IsAny<Expression<Func<Book, bool>>>()), Times.Once);
        }
    }
}