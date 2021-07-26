using BookSimpleAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookSimpleAPI.Data
{
    public class MockBook : IBook
    {
        public List<Book> Books()
        {
            throw new NotImplementedException();
        }

        public List<Book> GetBooksByDate(int Date, string tags)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetBooksByOrderDescription(string description)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetBooksByOrderPrice(int orderPrice)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetBooksByOrderTitle(string title)
        {
            throw new NotImplementedException();
        }

        public Book GetBookSignelByName(string name)
        {
            throw new NotImplementedException();
        }

        public Book GetBookSingle(int id)
        {
            throw new NotImplementedException();
        }
    }
}
