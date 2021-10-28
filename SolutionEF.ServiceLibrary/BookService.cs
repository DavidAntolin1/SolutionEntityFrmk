using SolutionEF.Core.Models;
using SolutionEF.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionEF.ServiceLibrary
{
    public class BookService : IBookService
    {
        private IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public List<Book> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }
    }
}
