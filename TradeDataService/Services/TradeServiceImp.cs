using Grpc.Core;
using ServiceContract;
using System.Threading.Tasks;
using TradeDataService.Repository;


namespace TradeDataService.Services
{
    public class TradeServiceImp : TradeService.TradeServiceBase
    {
        private readonly ITradeRepository tradeRepository;

        public TradeServiceImp(ITradeRepository tradeRepository)
        {
            this.tradeRepository = tradeRepository;
        }

        public override async Task FetchTradesStream(TradeRequest request, IServerStreamWriter<TradeResult> responseStream, ServerCallContext context)
        {
            var criterias = BuildCriteriaFromRequest(request);
            
            foreach (var trade in tradeRepository.FetchTrade(criterias))
            {
                if(context.CancellationToken.IsCancellationRequested)
                {
                    break;
                }
                var tradeResult = new TradeResult()
                {
                    Id = trade.ID,
                    Counterparty = trade.CounterParty,
                    Currency = trade.Currency,
                    Notional = trade.Notional
                };

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
