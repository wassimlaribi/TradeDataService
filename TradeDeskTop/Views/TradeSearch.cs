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
            this.viewPresenter.PropertyChanged += ViewPresenter_PropertyChanged;
            //Bing grid with view presenter trade list 
            tradesBindingSource1.DataSource = viewPresenter.TradeBindingList;
            tbTradeId.DataBindings.Add("Text", viewPresenter, "TradeId");

            tbCounterParty.DataBindings.Add("Text", viewPresenter, "CounterParty");
            lbLoadedTradeNumber.DataBindings.Add("Text", viewPresenter, "NumberOfTradeViewLabel", false, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void ViewPresenter_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("IsLoadingCompleted"))
            {
                StopProgressBar();
            }
        }

        private void StopProgressBar()
        {
            progressBar1.MarqueeAnimationSpeed = 0;
            progressBar1.Value = 100;
            progressBar1.Style = ProgressBarStyle.Continuous;
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            progressBar1.MarqueeAnimationSpeed = 50;
            progressBar1.Value = 0;
            progressBar1.Style = ProgressBarStyle.Marquee;
            viewPresenter.FetchTradesAsync();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            viewPresenter.CancelRequest();
        }
    }
}
