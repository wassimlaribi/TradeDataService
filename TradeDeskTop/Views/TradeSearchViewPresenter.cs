using Grpc.Core;
using ServiceContract;
using System.ComponentModel;
using System.Threading;

namespace TradeDeskTop.Views
{
    public class TradeSearchViewPresenter : INotifyPropertyChanged
    {
        public BindingList<TradeSearchModelPresenter> TradeBindingList = new BindingList<TradeSearchModelPresenter>();
        public string TradeId { get; set; }
        public string CounterParty { get; set; }

        private CancellationTokenSource tokenSource;

        public event PropertyChangedEventHandler PropertyChanged;

        public int NumberOfTrade { get; set; }

        private string numberOfTradeViewLabel = $"Loading 0";

        public string NumberOfTradeViewLabel
        {
            get => numberOfTradeViewLabel;
            set
            {
                numberOfTradeViewLabel = value;
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("NumberOfTradeViewLabel"));
            }
        }

        private bool isLoadingCompleted;
        public bool IsLoadingCompleted
        {
            get => isLoadingCompleted;
            set
            {
                isLoadingCompleted = value;
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("IsLoadingCompleted"));
            }
        }

        private void OnFetchStartViewUpdate()
        {
            //Reset cancellation token
            tokenSource = new CancellationTokenSource();
            //Clear grid 
            TradeBindingList.Clear();
            NumberOfTrade = 0;
            NumberOfTradeViewLabel = $"Loading {NumberOfTrade}";
        }

        private void OnFetchFinishedViewUpdate()
        {
            //Nofify view 
            NumberOfTradeViewLabel += " done";
            IsLoadingCompleted = false;
        }

        public async void FetchTradesAsync()
        {
            //Init grpc channel 
            Channel grpcChannel = new Channel("127.0.0.1:5000", ChannelCredentials.Insecure);
            try
            {
                //Reset View
                OnFetchStartViewUpdate();
                //Create client service
                var tradeServiceClient = new TradeService.TradeServiceClient(grpcChannel);
                //Build TradeRequest 
                var tradeRequest = BuildRequest();
                //Fetch result from server 
                using (var tradeServiceStreamer = tradeServiceClient.FetchTradesStream(tradeRequest))
                {
                    //Load next trade Async
                    while (await tradeServiceStreamer.ResponseStream.MoveNext(tokenSource.Token))
                    {
                        //Get current result
                        var tradeResult = tradeServiceStreamer.ResponseStream.Current;

                        //Build trade model presenter from result
                        var tradeSearchModelPresenter = new TradeSearchModelPresenter()
                        {
                            ID = tradeResult.Id,
                            CounterParty = tradeResult.Counterparty,
                            Currency = tradeResult.Currency,
                            Notional = tradeResult.Notional
                        };

                        //Update grid
                        TradeBindingList.Add(tradeSearchModelPresenter);
                        //Update number of trade label
                        NumberOfTradeViewLabel = $"Loading {NumberOfTrade++}";
                    }
                }
            }
            catch (RpcException e) when (e.Status.StatusCode == StatusCode.Cancelled)
            {
                tokenSource.Dispose();
            }
            finally
            {
                //Shutdown grpc channel
                grpcChannel.ShutdownAsync().Wait();
                //Update view
                OnFetchFinishedViewUpdate();
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
            if(tokenSource.IsCancellationRequested == false)
                tokenSource.Cancel();
        }
    }
}
