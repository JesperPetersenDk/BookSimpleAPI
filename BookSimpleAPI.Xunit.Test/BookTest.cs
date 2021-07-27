using BookSimpleAPI.Data;
using System;
using Xunit;

namespace BookSimpleAPI.Xunit.Test
{
    public class BookTest
    {
        private readonly MockBook _mockBook = new MockBook();

        [Fact]
        public void GetListWithBook()
        {
            var result = _mockBook.GetBooks();
            Assert.NotNull(result);
        }
    }
}
