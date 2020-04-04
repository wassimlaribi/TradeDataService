using System;
using System.Windows.Forms;
using TradeDeskTop.Views;

namespace TradeDeskTop
{
    public partial class TradeSearch : Form
    {
        public TradeSearchViewPresenter viewPresenter;
        public TradeSearch(TradeSearchViewPresenter viewPresenter)
        {
            InitializeComponent();
            // create view presenter
            this.viewPresenter = viewPresenter;
            //Binding 
            tradesBindingSource1.DataSource = viewPresenter.TradeBindingList;
            tbTradeId.DataBindings.Add("Text", viewPresenter, "TradeId");
            tbCounterParty.DataBindings.Add("Text", viewPresenter, "CounterParty");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            viewPresenter.FetchTradesAsync();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            viewPresenter.CancelRequest();
        }
    }
}
