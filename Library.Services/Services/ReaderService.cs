using Library.Core.Models;
using Library.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Services
{
    class ReaderService : IReaderService
    {
        public Task<Reader> Create(Reader reader)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();

        }

        public Task<Reader> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Reader> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Reader> Update(int id, Reader reader)
        {
            throw new NotImplementedException();
        }
    }
}
