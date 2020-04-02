using Grpc.Core;
using ServiceContract;
using System.Threading.Tasks;
using TradeDataService.Domain;
using TradeDataService.Repository;


namespace TradeDataService.Services
{
    public class TradeServiceImp : TradeService.TradeServiceBase
    {
        private static readonly TradeRepository tradeRepository = new TradeRepository();

        public override async Task GetAllTradesStream(TradeRequest request, IServerStreamWriter<TradeResult> responseStream, ServerCallContext context)
        {
            foreach (var trade in tradeRepository.GetAll())
            {
                var tradeResultContract = new TradeResult()
                {
                    Id = trade.ID,
                    Counterparty = trade.CounterParty,
                    Currency = trade.Currency,
                    Notional = trade.Notional
                };

                await responseStream.WriteAsync(tradeResultContract);
            }
        }

        public override Task<TradeResult> GetTradeById(TradeRequest request, ServerCallContext context)
        {
            Trade trade = tradeRepository.GetTradeById(request.Id);

            var tradecontract = new TradeResult();

            if (trade != null)
            {
                tradecontract.Id = trade.ID;
                tradecontract.Counterparty = trade.CounterParty;
                tradecontract.Currency = trade.Currency;
                tradecontract.Notional = trade.Notional;
            }

            return Task.FromResult(tradecontract);
        }
    }
}
