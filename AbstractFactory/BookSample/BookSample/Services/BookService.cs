using BookSample.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookSample.Services
{
    public class BookService : IBookService
    {
        private readonly IRepositoryFactory factory;

        public BookService(IRepositoryFactory factory)
        {
            this.factory = factory;
        }

        public void CreateBook(string title, string author)
        {
            throw new NotImplementedException();
        }

        public ICollection<string> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public ICollection<string> GetBooks(string query)
        {
            throw new NotImplementedException();
        }
    }
}
