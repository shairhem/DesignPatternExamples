using System;
using System.Collections.Generic;
using System.Text;

namespace BookSample.Repositories
{
    public interface IBookRepository
    {
        void Insert(string value);

        string Get(string value);

        string GetAll();
    }
}
