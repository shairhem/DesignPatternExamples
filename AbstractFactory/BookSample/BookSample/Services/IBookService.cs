using System;
using System.Collections.Generic;
using System.Text;

namespace BookSample.Services
{
    public interface IBookService
    {
        void CreateBook(string title, string author);

        ICollection<string> GetBooks(string query);

        ICollection<string> GetAllBooks();
    }
}
