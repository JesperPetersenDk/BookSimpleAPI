using BookSimpleAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookSimpleAPI.Data
{
    public interface IBook
    {

        List<Book> GetBooks();
        Book GetBookSingle(int id);
        Book GetBookSignelByName(string name);
        List<Book> GetBooksByOrderPrice(int orderPrice);
        List<Book> GetBooksByDate(int Date, string tags);

    }
}
