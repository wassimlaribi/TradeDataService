
using Grpc.Core;
using Grpc.Net.Client;
using ServiceContract;
using System;
using System.Collections.Generic;
using System.Text;


namespace GrpcTradeServiceClient
{
	class TradeStreamer
	{
		public async IAsyncEnumerable<TradeResult> GetAllAsync()
		{
			var grpcChannel = GrpcChannel.ForAddress("https://localhost:5001");

			var tradeServiceClient = new TradeService.TradeServiceClient(grpcChannel);

			using (var tradeServiceStreamer = tradeServiceClient.FetchTradesStream(new TradeRequest()))
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
