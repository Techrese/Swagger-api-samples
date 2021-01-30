using Microsoft.AspNetCore.Mvc;
using Swagger_Samples.Models;
using System.Net;

namespace Swagger_Samples.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly BookRepository bookRepository;
        private readonly ApplicationDbContext _context;

        public BookController(ApplicationDbContext context)
        {
            _context = context;
            bookRepository = new BookRepository(context);
        }

        
        [Route("addbook")]
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(Book))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult CreateBook(Book book)
        {
            if (ModelState.IsValid)
            {
                bookRepository.AddBook(book);
                return Ok(book);
            }
            else
            {
                return BadRequest();
            }
            
        }


    }
}
