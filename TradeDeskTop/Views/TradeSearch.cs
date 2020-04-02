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
            var tradeRequest = BuildRequest();

            if (tradeRequest.Id > 0)
            {
                GetTradeById(tradeRequest.Id);
            }
            else
            {
                GetAllTradesAsync();
            }
        }

        private TradeRequest BuildRequest()
        {
            var tradeRequest = new TradeRequest();

            if (!string.IsNullOrWhiteSpace(tbTradeId.Text))
                tradeRequest.Id = int.Parse(tbTradeId.Text);

            return tradeRequest;
        }

        private void GetTradeById(int id)
        {

        }

        public async void GetAllTradesAsync()
        {
            var grpcChannel = new Channel("127.0.0.1:5000", ChannelCredentials.Insecure);
            var tradeServiceClient = new TradeService.TradeServiceClient(grpcChannel);

            using (var tradeServiceStreamer = tradeServiceClient.GetAllTradesStream(new TradeRequest()))
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
