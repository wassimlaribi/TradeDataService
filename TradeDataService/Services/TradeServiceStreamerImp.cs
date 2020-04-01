using Greeter;
using Grpc.Core;
using System.Threading.Tasks;
using TradeDataService.Repository;


namespace TradeDataService.Services
{
    public class TradeServiceStreamerImp : Greeter.TradeServiceStreamer.TradeServiceStreamerBase
    {
        private static readonly TradeRepository tradeRepository = new TradeRepository();

        public override async Task GetAllTrades(TradeRequest request, IServerStreamWriter<TradeDataContract> responseStream, ServerCallContext context)
        {
            foreach (var trade in tradeRepository.GetAll())
            {
                var tradeDataContract = new TradeDataContract()
                {
                    Id = trade.ID,
                    Counterparty = trade.CounterParty,
                    Currency = trade.Currency,
                    Notional = trade.Notional
                };

                await responseStream.WriteAsync(tradeDataContract);
            }
        }
    }
}
