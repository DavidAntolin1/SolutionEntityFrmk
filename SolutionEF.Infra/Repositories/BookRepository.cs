using SolutionEF.Core.Models;
using SolutionEF.Core.Services;
using SolutionEF.Infra.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionEF.Infra.Repositories
{
    public class BookRepository : IBookRepository
    {
        protected readonly SolutionEFContext _context;
        protected readonly DbSet<Book> _entities;
        public BookRepository(SolutionEFContext context)
        {
            _context = context;
            _entities = context.Set<Book>();
        }
        public List<Book> GetAllBooks()
        {
            try
            {
                var entity = _entities.ToList();
                return entity;
            }
            catch
            {
                return null;
            }
        }
    }
}
