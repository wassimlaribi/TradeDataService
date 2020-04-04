using Grpc.Core;
using ServiceContract;
using System.ComponentModel;
using System.Threading;

namespace TradeDeskTop.Views
{
	public class TradeSearchViewPresenter
	{
		public BindingList<TradeSearchModelPresenter> TradeBindingList = new BindingList<TradeSearchModelPresenter>();
		public string TradeId { get; set; }
		public string CounterParty { get; set; }

        private CancellationTokenSource tokenSource;

        public async void FetchTradesAsync()
        {
            // init grpc channel 
            Channel grpcChannel = new Channel("127.0.0.1:5000", ChannelCredentials.Insecure);
            // Reset cancellation token
            tokenSource = new CancellationTokenSource();
            //Clear grid 
            TradeBindingList.Clear();
            try
            {
                var tradeServiceClient = new TradeService.TradeServiceClient(grpcChannel);

                //Build TradeRequest 
                var tradeRequest = BuildRequest();
                //fetch result from server 
                using (var tradeServiceStreamer = tradeServiceClient.FetchTradesStream(tradeRequest))
                {
                    while (await tradeServiceStreamer.ResponseStream.MoveNext(tokenSource.Token))
                    {
                        var tradeResult = tradeServiceStreamer.ResponseStream.Current;

                        var tradeSearchModelPresenter = new TradeSearchModelPresenter()
                        {
                            ID = tradeResult.Id,
                            CounterParty = tradeResult.Counterparty,
                            Currency = tradeResult.Currency,
                            Notional = tradeResult.Notional
                        };

                        TradeBindingList.Add(tradeSearchModelPresenter);
                    }
                }
            }
            catch (RpcException e) when (e.Status.StatusCode == StatusCode.Cancelled)
            {
                tokenSource.Dispose();
               
            }
            finally
            {
                grpcChannel.ShutdownAsync().Wait();
            }
            
        }

        private TradeRequest BuildRequest()
        {
            var tradeRequest = new TradeRequest();

            if (!string.IsNullOrWhiteSpace(TradeId))
                tradeRequest.Id = int.Parse(TradeId);

            if (!string.IsNullOrWhiteSpace(CounterParty))
                tradeRequest.Counterparty = CounterParty;

            return tradeRequest;
        }

        public void CancelRequest()
        {
            tokenSource.Cancel();
        }
    }
}
