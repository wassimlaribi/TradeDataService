using System.Collections.Generic;
using TradeDataService.Domain;

namespace TradeDataService.Repository
{
	public interface ITradeRepository
	{
		IEnumerable<Trade> FetchTrade(Criterias criteria);
		Trade GetTradeById(int id);
	}
}
