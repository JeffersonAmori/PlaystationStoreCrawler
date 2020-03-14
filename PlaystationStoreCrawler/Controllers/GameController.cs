using MediatR;
using Microsoft.AspNetCore.Mvc;
using PlaystationStoreCrawler.Core.Search.Queries;
using PlaystationStoreCrawler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationStoreCrawler.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GameController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<GameSearchResult> Get(string gameName)
        {
            var result = new GameSearchResult("", 0d, 0d);

            await _mediator.Send(new GameSearchQuery(gameName));

            return  result;
        }
    }
}
