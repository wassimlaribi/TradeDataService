using System;
using System.Windows.Forms;
using Grpc.Core;
using Greeter;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel;

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
            GetAllAsync();
        }

        public async void GetAllAsync()
        {
            var grpcChannel = new Channel("127.0.0.1:5000", ChannelCredentials.Insecure);

            var tradeServiceClient = new TradeServiceStreamer.TradeServiceStreamerClient(grpcChannel);

            using (var tradeServiceStreamer = tradeServiceClient.GetAllTrades(new TradeRequest()))
            {
                while (await tradeServiceStreamer.ResponseStream.MoveNext())
                {
                    var tradeDataContract = tradeServiceStreamer.ResponseStream.Current;

                    //yield return tradeDataContract;
                    var tradeSearchModelPresenter = new TradeSearchModelPresenter()
                    {
                        ID = tradeDataContract.Id,
                        CounterParty = tradeDataContract.Counterparty,
                        Currency = tradeDataContract.Currency,
                        Notional = tradeDataContract.Notional
                    };

                    bindingList.Add(tradeSearchModelPresenter);
                }
            }
        }
    }
}
