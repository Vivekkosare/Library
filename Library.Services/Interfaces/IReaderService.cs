using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Library.Core.Models;

namespace Library.Services.Interfaces
{
    public interface IReaderService
    {
        Task<Reader> GetAll();
        Task<Reader> Get(int id);
        Task<Reader> Create(Reader reader);
        Task<Reader> Update(int id, Reader reader);
        void Delete(int id);
    }
}
