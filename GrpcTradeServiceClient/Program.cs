using Grpc.Core;
using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace GrpcTradeServiceClient
{
	class Program
	{
		static async System.Threading.Tasks.Task Main(string[] args)
		{
			TradeStreamer tradeStreamer = new TradeStreamer();

			await foreach (var trade in tradeStreamer.GetAllAsync())
			{
				Console.WriteLine($"id : {trade.Id} , counterparty {trade.Counterparty}");
			}

			Console.ReadKey();

		}
	}
}
