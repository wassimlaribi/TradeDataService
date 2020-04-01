using Greeter;
using Grpc.Core;
using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Text;


namespace GrpcTradeServiceClient
{
	class TradeStreamer
	{
		public async IAsyncEnumerable<TradeDataContract> GetAllAsync()
		{
			var grpcChannel = GrpcChannel.ForAddress("https://localhost:5001");

			var tradeServiceClient = new Greeter.TradeServiceStreamer.TradeServiceStreamerClient(grpcChannel);

			using (var tradeServiceStreamer = tradeServiceClient.GetAllTrades(new TradeRequest()))
			{
				while (await tradeServiceStreamer.ResponseStream.MoveNext())
				{
					var tradeDataContract = tradeServiceStreamer.ResponseStream.Current;

					yield return tradeDataContract;
				}
			}
		}
	}
}
