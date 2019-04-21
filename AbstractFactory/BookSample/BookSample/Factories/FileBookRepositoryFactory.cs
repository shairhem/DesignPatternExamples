using System;
using System.Collections.Generic;
using System.Text;

namespace BookSample.Factories
{
    public class FileBookRepositoryFactory : IRepositoryFactory
    {
        public void CreateAuthorRepository()
        {
            Console.WriteLine("Author Repository has been create on the filesystem!");
        }

        public void CreateBookRepository()
        {
            Console.WriteLine("Book Repository has been create on the filesystem!");
        }
    }
}
