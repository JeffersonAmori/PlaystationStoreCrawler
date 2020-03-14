using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PlaystationStoreCrawler.Core.Search.Queries
{
    public class GameSearchQuery : IRequest<GameSearchRequestResult>
    {
        public GameSearchQuery(string gameName)
        {
            GameName = gameName;
        }


        public string GameName { get; set; }
    }

    public class GameSearchQueryHandler : IRequestHandler<GameSearchQuery, GameSearchRequestResult>
    {

        public Task<GameSearchRequestResult> Handle(GameSearchQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
