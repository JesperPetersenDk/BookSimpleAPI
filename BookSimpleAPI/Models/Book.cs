using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookSimpleAPI.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public DateTime DateTime { get; set; }
    }
}
