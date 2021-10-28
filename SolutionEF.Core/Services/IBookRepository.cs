using SolutionEF.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionEF.Core.Services
{
    public interface IBookRepository
    {
        List<Book> GetAllBooks();
    }
}
