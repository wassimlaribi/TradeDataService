using Grpc.Core;
using ServiceContract;
using System.Threading.Tasks;
using TradeDataService.Repository;


namespace TradeDataService.Services
{
    public class TradeServiceImp : TradeService.TradeServiceBase
    {
        private readonly ITradeRepository tradeRepository;

        //TradeRepository is a Singleton class, it will be injected 
        public TradeServiceImp(ITradeRepository tradeRepository)
        {
            this.tradeRepository = tradeRepository;
        }

        public override async Task FetchTradesStream(TradeRequest request, IServerStreamWriter<TradeResult> responseStream, ServerCallContext context)
        {
            //using Criteria class to decouple the database from the contract "TradeRequest"
            var criterias = BuildCriteriaFromRequest(request);

            foreach (var trade in tradeRepository.FetchTrade(criterias))
            {
                //Client could cancel the request at any time with this token 
                if (context.CancellationToken.IsCancellationRequested)
                {
                    break;
                }

                //Build TradeResult
                var tradeResult = new TradeResult()
                {
                    Id = trade.ID,
                    Counterparty = trade.CounterParty,
                    Currency = trade.Currency,
                    Notional = trade.Notional
                };
                //Return the result async 
                await responseStream.WriteAsync(tradeResult);
            }
        }

        private Criterias BuildCriteriaFromRequest(TradeRequest request)
        {
            return new Criterias
            {
                Id = request.Id,
                CounterParty = request.Counterparty
            };
        }
    }
}
