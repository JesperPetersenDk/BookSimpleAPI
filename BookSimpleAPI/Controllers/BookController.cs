using BookSimpleAPI.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;


namespace BookSimpleAPI.Controllers
{
    [Route("api/book")]
    [ApiController]
    public class BookController : ControllerBase
    {

        private readonly IBook _book;
        public BookController(IBook book)
        {
            _book = book;
        }


        [HttpGet("all")]
        public ActionResult<IEnumerable<MockBook>> GetAll()
        {
            try
            {
                var result = _book.GetBooks();
                return Ok(result);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpGet("DateAndTags/{days}/{tags}")]
        public ActionResult <MockBook> GetBooksByDate(int days, string tags)
        {
            try
            {
                var resultBook = _book.GetBooksByDate(days, tags);
                return Ok(resultBook);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult <MockBook> GetSingleById(int id)
        {
            try
            {
                var result = _book.GetBookSingle(id);
                return Ok(result);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
