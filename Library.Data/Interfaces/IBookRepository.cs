using Library.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Interfaces
{
    public interface IBookRepository
    {
        Task<Book> GetAll();
        Task<Book> Get(int id);
        void Create(Book book);
        Task<Book> Update(int id, Book book);
        void Delete(int id);
    }
}
