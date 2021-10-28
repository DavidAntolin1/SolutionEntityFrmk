using SolutionEF.Core.Models;
using SolutionEF.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SolutionEFApi.Controllers
{
    public class BookController : ApiController
    {
        private IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        // GET: api/Book
        public List<Book> Get()
        {
            return _bookService.GetAllBooks();
        }
    }
}
