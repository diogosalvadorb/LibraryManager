using LibraryManager.Application.Commands.LoanCommands.CreateLoan;
using LibraryManager.Application.Commands.LoanCommands.FinishLoan;
using LibraryManager.Application.Queries.LoanQueries.GetLoanById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanController : ControllerBase
    {
        private readonly IMediator _mediator;
        public LoanController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLoanById([FromRoute] int id)
        {
            var loan = await _mediator.Send(new GetLoanByIdQuery(id));

            if (loan == null)
                return NotFound();

            return Ok(loan);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateLoanCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetLoanById), new { Id = id }, command);
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> FinishLoan([FromRoute] int id)
        {
            var loan = await _mediator.Send(new FinishLoanCommand(id));

            if (loan == null)
                return NotFound();

            return Ok(loan);
        }
    }
}
