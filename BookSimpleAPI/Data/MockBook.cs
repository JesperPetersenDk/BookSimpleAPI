using BookSimpleAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookSimpleAPI.Helper.Extensions;

namespace BookSimpleAPI.Data
{
    public class MockBook : IBook
    {
        private static List<Book> BookList()
        {
            var book = new List<Book>()
            {
                new Book {BookId = 1,  DateTime = new DateTime(2021, 1, 1), Name="Book Simple API", Price = 251, Title = "Google API Test"},
                new Book {BookId = 2,  DateTime = new DateTime(2021, 7, 25),Name="Datamatiker", Price = 99, Title = "Google API Test"},
                new Book {BookId = 3,  DateTime = new DateTime(2021, 5, 25), Name="Book Simple API", Price = 863, Title = "Google API Test"},
                new Book {BookId = 4,  DateTime = new DateTime(2021, 8, 25), Name="Software", Price = 450, Title = "Google API Test"},
                new Book {BookId = 5,  DateTime = new DateTime(2021, 4, 25), Name="Book", Price = 467, Title = "Google API Test"},
                new Book {BookId = 6,  DateTime = new DateTime(2021, 3, 25),Name="Testing", Price = 32, Title = "Google API Test"}
            };
            return book;           
        }


        public List<Book> GetBooks()
        {
            return BookList();
        }

        public List<Book> GetBooksByOrderPrice(int orderPrice)
        {
            throw new NotImplementedException();
        }

        public Book GetBookSignelByName(string name)
        {
            throw new NotImplementedException();
        }

        public Book GetBookSingle(int id)
        {
            return BookList().FirstOrDefault(r => r.BookId == id);
        }
    }
}
