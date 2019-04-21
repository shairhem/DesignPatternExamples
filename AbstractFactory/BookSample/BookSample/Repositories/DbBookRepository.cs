using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BookSample.Repositories
{
    public class DbBookRepository : IBookRepository
    {
        string filename = "./file.txt";

        public string Get(string value)
        {
            var contents = File.ReadAllLines(this.filename);
            var result = contents.FirstOrDefault(x => x == value);
            return result;
        }

        public string GetAll()
        {
            string content = File.ReadAllText(this.filename);
            return content;
        }

        public void Insert(string value)
        {
            File.AppendAllText(this.filename, value);
        }
    }
}
