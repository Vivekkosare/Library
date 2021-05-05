using Library.Data.DBContexts;
using Library.Data.Entities;
using Library.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryContext _context;
        public BookRepository( LibraryContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void Create(Book book)
        {
            if(book == null)
                throw new ArgumentNullException(nameof(book));
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Book> Get(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
                throw new Exception("Book is not available");
            return book;
        }

        public Task<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Book> Update(int id, Book book)
        {
            throw new NotImplementedException();
        }
    }
}
