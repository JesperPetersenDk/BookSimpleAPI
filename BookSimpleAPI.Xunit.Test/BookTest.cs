using BookSimpleAPI.Data;
using BookSimpleAPI.Helper.Extensions;
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
        [InlineData(1, "")]
        [InlineData(325235, "")]
        public void GetSingleBookByTagsAndDateIsNullByEmptyTags(int day, string tags)
        {
            var resultData = new ExtensionsData();
            var result = _mockBook.GetBooks();
            var completeResult = resultData.ByDateAndTags(result, day, tags);
            Assert.Null(completeResult);
        }

        [Theory]
        [InlineData(-10, "stor")]
        [InlineData(-1, "big")]
        public void GetSingleBookByTagsAndDateIsNullByNegative(int day, string tags)
        {
            var resultData = new ExtensionsData();
            var result = _mockBook.GetBooks();
            var completeResult = resultData.ByDateAndTags(result, day, tags);
            Assert.Null(completeResult);
        }

        [Theory]
        [InlineData(10, "stor")]
        [InlineData(1, "big")]
        public void GetSingleBookByTagsAndDateIsNotNullBySuccess(int day, string tags)
        {
            var resultData = new ExtensionsData();
            var result = _mockBook.GetBooks();
            var completeResult = resultData.ByDateAndTags(result, day, tags);
            Assert.NotNull(completeResult);
        }

        [Theory]
        [InlineData(-10, "")]
        [InlineData(-1, "")]
        public void GetSingleBookByTagsAndDateIsNullByNegativeAndEmptyTags(int day, string tags)
        {
            var resultData = new ExtensionsData();
            var result = _mockBook.GetBooks();
            var completeResult = resultData.ByDateAndTags(result, day, tags);
            Assert.Null(completeResult);
        }

        [Theory]
        [InlineData(1, "Book")]
        [InlineData(4, "Hej med dig")]
        public void GetSingleBookByTagsAndDateIsNull_NotTagsMatch(int day, string tags)
        {
            var resultData = new ExtensionsData();
            var result = _mockBook.GetBooks();
            var completeResult = resultData.ByDateAndTags(result, day, tags);
            Assert.Null(completeResult);
        }

        [Theory]
        [InlineData("e")]
        [InlineData("Yi Yi")]
        [InlineData("Datamatiker")]
        [InlineData("Google API Test")]
        public void GetBookDataBySingleWord_IsNotNull(string name)
        {
            var resultData = new ExtensionsData();
            var result = _mockBook.GetBooks();
            var completeResult = resultData.FindNameAndTitleOnBooks(result, name);
            Assert.NotNull(completeResult);
        }

        [Theory]
        [InlineData("Hej med dig vi tester")]
        [InlineData("x-gamer")]
        [InlineData("Hej Jesper")]
        public void GetBookDataBySingleWord_IsNull(string name)
        {
            var resultData = new ExtensionsData();
            var result = _mockBook.GetBooks();
            var completeResult = resultData.FindNameAndTitleOnBooks(result, name);
            Assert.Null(completeResult);
        }
    }
}
