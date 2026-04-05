using razorassessment.Helper;
using razorassessment.Models;


namespace razorassessment.Interface
{
    public interface IBookRepository
    {
        public Task<List<Book>> GetAllBooksAsync();


        public Task<Book> GetBookByIdAsync(int id);


        public Task<Book> AddBookAsync(Book book);


        public Task<Book> DeleteBookAsync(int id);

    }
}
