using BookSimpleAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookSimpleAPI.Data
{
    public interface IBook
    {

        List<Book> Books();
        Book GetBookSingle(int id);
        Book GetBookSignelByName(string name);
        List<Book> GetBooksByOrderPrice(int orderPrice);
        List<Book> GetBooksByOrderTitle(string title);
        List<Book> GetBooksByOrderDescription(string description);
        List<Book> GetBooksByDate(int Date, string tags);

    }
}
