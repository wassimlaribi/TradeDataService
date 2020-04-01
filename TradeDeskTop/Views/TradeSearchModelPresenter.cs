using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeDeskTop
{
	public class TradeSearchModelPresenter
	{
		public int ID { get; set; }
		public string CounterParty { get; set; }
		public string Currency { get; set; }
		public int Notional { get; set; }
	}
}
