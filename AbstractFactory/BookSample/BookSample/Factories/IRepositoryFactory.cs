using System;
using System.Collections.Generic;
using System.Text;

namespace BookSample.Factories
{
    public interface IRepositoryFactory
    {
        void CreateBookRepository();

        void CreateAuthorRepository();
    }
}
