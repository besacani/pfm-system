using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pfmservice.Models;
using pfmservice.Commands;


namespace pfmservice.Controllers
{
    [ApiController]
    [Route("transactions")]

    public class TransactionsController : ControllerBase
    {
        private readonly ILogger<TransactionsController> _logger;

        public TransactionsController(ILogger<TransactionsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetTransactions([FromQuery] string TransactionKind, [FromQuery] DateTime? StartDate, [FromQuery] DateTime? EndDate, [FromQuery] int? Page, [FromQuery] int? PageSize,
                                                [FromQuery] SortBy sortBy, [FromQuery] SortOrder sortOrder)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetTransaction([FromRoute] int id)
        {
            return Ok();
        }

        [HttpPost("import")]
        public IActionResult CreateTransaction([FromBody] CreateProductCommand command)
        {
            return Ok();
        }


        [HttpPost("/transaction/{id}/categorize")]
        public IActionResult CategorizeTransaction([FromRoute] int id)
        {
            return Ok();
        }


        [HttpPost("/transaction/{id}/split")]
        public IActionResult SplitTransaction([FromRoute] int id)
        {
            return Ok();
        }



    }
}