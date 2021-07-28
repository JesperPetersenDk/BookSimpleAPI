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

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        public void GetSingleBookNotNull(int id)
        {
            var result = _mockBook.GetBookSingle(id);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-2)]
        [InlineData(-3)]
        [InlineData(-4)]
        public void GetSingleBookIsNull(int id)
        {
            var result = _mockBook.GetBookSingle(id);
            Assert.Null(result);
        }

        [Theory]
        [InlineData(1, "big")]
        [InlineData(2, "big")]
        [InlineData(3, "bigger")]
        public void GetSingleBookByTagsAndDate(int day, string tags)
        {
            var result = _mockBook.GetBooksByDate(day, tags);
            Assert.NotNull(result);
        }
    }
}
