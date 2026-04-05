using razorassessment.Helper;
using razorassessment.Models;
using razorassessment.Dto;




namespace razorassessment.Interface
{
    public interface IBookService
    {

        public Task<List<BookDto>> GetAllBooksAsync();


        public Task<BookDto> GetBookByIdAsync(int id);


        public Task<BookDto> AddBookAsync();


        public Task<BookDto> DeleteBookAsync(int id);

    }
}
