﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TradeDataService.Domain
{
	//Internal domain model
	public class Trade
	{
		public Trade()
		{
			CounterParty = string.Empty;
			Currency = string.Empty;
			
		}

		public int ID { get; set; }
		public string CounterParty { get; set; }
		public string Currency { get; set; }
		public int Notional { get; set; }
	}
}
