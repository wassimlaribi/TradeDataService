using System;
using System.Windows.Forms;
using Grpc.Core;
using System.ComponentModel;
using ServiceContract;

namespace TradeDeskTop
{
    public partial class TradeSearch : Form
	{
        public BindingList<TradeSearchModelPresenter> bindingList = new BindingList<TradeSearchModelPresenter>();
        public TradeSearch()
		{
			InitializeComponent();
            tradesBindingSource1.DataSource = bindingList;
		}

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bindingList.Clear();
            var tradeRequest = BuildRequest();
            FetchTradesAsync(tradeRequest);
        }

        private TradeRequest BuildRequest()
        {
            var tradeRequest = new TradeRequest();

            if (!string.IsNullOrWhiteSpace(tbTradeId.Text))
                tradeRequest.Id = int.Parse(tbTradeId.Text);

            if (!string.IsNullOrWhiteSpace(tbCounterParty.Text))
                tradeRequest.Counterparty = tbCounterParty.Text;

            return tradeRequest;
        }

        public async void FetchTradesAsync(TradeRequest tradeRequest)
        {
            var grpcChannel = new Channel("127.0.0.1:5000", ChannelCredentials.Insecure);
            var tradeServiceClient = new TradeService.TradeServiceClient(grpcChannel);

            using (var tradeServiceStreamer = tradeServiceClient.FetchTradesStream(tradeRequest))
            {
                while (await tradeServiceStreamer.ResponseStream.MoveNext())
                {
                    var tradeResult = tradeServiceStreamer.ResponseStream.Current;
                    
                    var tradeSearchModelPresenter = new TradeSearchModelPresenter()
                    {
                        ID = tradeResult.Id,
                        CounterParty = tradeResult.Counterparty,
                        Currency = tradeResult.Currency,
                        Notional = tradeResult.Notional
                    };

                    bindingList.Add(tradeSearchModelPresenter);
                }
            }
        }
    }
}
