using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TradeDataService.Domain;

namespace TradeDataService.Repository
{
	//Memory implementation of ITradeRepository
	public class TradeRepository : ITradeRepository
	{
		private readonly List<string> counterParties = new List<string> { "Gold", "AIR", "JPM", "SG", "Natixis" };
		private readonly List<string> currencies = new List<string> { "USD", "EUR", "HKD", "AUD", "GBP" };
		private readonly List<int> notionals = new List<int> { 100000,200000,300000,400000,500000 };
		private readonly Dictionary<int, Trade> trades = new Dictionary<int, Trade>();

		//create a memory database of trade 
		public TradeRepository()
		{
			CreateTradesDb();
		}

		//simulate the fetch method from the database
		//
		public IEnumerable<Trade> FetchTrade(Criterias criteria)
		{

			if (criteria.Id > 0)
			{
				yield return GetTradeById(criteria.Id);
			}
			else
			{
				foreach (var trade in trades.Values)
				{
					if(!string.IsNullOrWhiteSpace(criteria.CounterParty))
					{
						if(!trade.CounterParty.Equals(criteria.CounterParty))
						{
							continue;
						}
					}

					Task.Delay(300).Wait();
					yield return trade;
				}
			}
		}

		public Trade GetTradeById(int id)
		{
			if(trades.TryGetValue(id, out Trade result))
				return result;

			//return empty trade
			result = new Trade();

			return result;
		}

		//Create a fake memory database 
		private void CreateTradesDb()
		{
			var random = new Random();

			for (int i = 0; i < 100; i++)
			{
				var trade = new Trade
				{
					ID = i,
					CounterParty = counterParties[random.Next(0, 5)],
					Currency = currencies[random.Next(0, 5)],
					Notional = notionals[random.Next(0, 5)]
				};

				trades.Add(trade.ID, trade);
			}
		}

	}
}
