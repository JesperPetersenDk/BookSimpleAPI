using BookSimpleAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookSimpleAPI.Data
{
    public class MockBook : IBook
    {
        private static List<Book> BookList()
        {
            var book = new List<Book>()
            {
                new Book {BookId = 1, Author = "Google", DateTime = new DateTime(2021, 1, 1), Description="for IT og øje for detaljer, er datamatiker lige noget for dig. Som datamatiker", Name="Book Simple API", Price = 450, Title = "Google API Test"},
                new Book {BookId = 1, Author = "Google", DateTime = new DateTime(2021, 7, 25), Description="for IT og øje for detaljer, er datamatiker lige noget for dig. Som datamatiker", Name="Book Simple API", Price = 450, Title = "Google API Test"},
                new Book {BookId = 1, Author = "Google", DateTime = new DateTime(2021, 1, 1), Description="for IT og øje for detaljer, er datamatiker lige noget for dig. Som datamatiker", Name="Book Simple API", Price = 450, Title = "Google API Test"},
                new Book {BookId = 1, Author = "Google", DateTime = new DateTime(2021, 1, 1), Description="for IT og øje for detaljer, er datamatiker lige noget for dig. Som datamatiker", Name="Book Simple API", Price = 450, Title = "Google API Test"},
                new Book {BookId = 1, Author = "Google", DateTime = new DateTime(2021, 1, 1), Description="for IT og øje for detaljer, er datamatiker lige noget for dig. Som datamatiker", Name="Book Simple API", Price = 450, Title = "Google API Test"},
                new Book {BookId = 1, Author = "Google", DateTime = new DateTime(2021, 1, 1), Description="for IT og øje for detaljer, er datamatiker lige noget for dig. Som datamatiker", Name="Book Simple API", Price = 450, Title = "Google API Test"}
            };
            return book;           
        }


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
