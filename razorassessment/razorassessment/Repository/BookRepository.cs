using razorassessment.Helper;
using razorassessment.Models;
using razorassessment.Dto;
using razorassessment.Interface;





namespace razorassessment.Repository
{
    public class BookRepository : IBookRepository
    {

        private readonly AppDbContext _context;



        public BookRepository (AppDbContext context)
        {
            _context = context;
        }


        public async Task <List<Book>>


    }
}
