using LibraryManager.Application.Commands.BookCommands.CreateBook;
using LibraryManager.Application.Queries.BookQueries.GetAllBook;
using LibraryManager.Application.Queries.BookQueries.GetBookById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BookController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var books = await _mediator.Send(new GetAllBooksQuery());

            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById([FromRoute] int id)
        {
            var book = await _mediator.Send(new GetBookByIdQuery(id));

            if (book == null)
                return NotFound();

            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateBookCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetBookById), new { Id = id }, command);
        }
    }
}
