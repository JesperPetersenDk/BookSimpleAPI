using BookSimpleAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookSimpleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {

        private readonly IBook _book;
        public BookController(IBook book)
        {
            _book = book;
        }


        [HttpGet]
        public ActionResult<IEnumerable<MockBook>> GetAll()
        {
            try
            {
                var commandItem = _book.GetBooks();
                return Ok(commandItem);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
