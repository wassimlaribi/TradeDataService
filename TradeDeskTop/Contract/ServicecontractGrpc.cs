// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TradeDeskTop/protos/servicecontract.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ServiceContract {
  /// <summary>
  /// Trade service definition.
  /// </summary>
  public static partial class TradeService
  {
    static readonly string __ServiceName = "ServiceContract.TradeService";

    static readonly grpc::Marshaller<global::ServiceContract.TradeRequest> __Marshaller_ServiceContract_TradeRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ServiceContract.TradeRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::ServiceContract.TradeResult> __Marshaller_ServiceContract_TradeResult = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ServiceContract.TradeResult.Parser.ParseFrom);

    static readonly grpc::Method<global::ServiceContract.TradeRequest, global::ServiceContract.TradeResult> __Method_GetAllTradesStream = new grpc::Method<global::ServiceContract.TradeRequest, global::ServiceContract.TradeResult>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetAllTradesStream",
        __Marshaller_ServiceContract_TradeRequest,
        __Marshaller_ServiceContract_TradeResult);

    static readonly grpc::Method<global::ServiceContract.TradeRequest, global::ServiceContract.TradeResult> __Method_GetTradeById = new grpc::Method<global::ServiceContract.TradeRequest, global::ServiceContract.TradeResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetTradeById",
        __Marshaller_ServiceContract_TradeRequest,
        __Marshaller_ServiceContract_TradeResult);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ServiceContract.ServicecontractReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of TradeService</summary>
    [grpc::BindServiceMethod(typeof(TradeService), "BindService")]
    public abstract partial class TradeServiceBase
    {
      public virtual global::System.Threading.Tasks.Task GetAllTradesStream(global::ServiceContract.TradeRequest request, grpc::IServerStreamWriter<global::ServiceContract.TradeResult> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::ServiceContract.TradeResult> GetTradeById(global::ServiceContract.TradeRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for TradeService</summary>
    public partial class TradeServiceClient : grpc::ClientBase<TradeServiceClient>
    {
      /// <summary>Creates a new client for TradeService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public TradeServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for TradeService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public TradeServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected TradeServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected TradeServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncServerStreamingCall<global::ServiceContract.TradeResult> GetAllTradesStream(global::ServiceContract.TradeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllTradesStream(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::ServiceContract.TradeResult> GetAllTradesStream(global::ServiceContract.TradeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetAllTradesStream, null, options, request);
      }
      public virtual global::ServiceContract.TradeResult GetTradeById(global::ServiceContract.TradeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetTradeById(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::ServiceContract.TradeResult GetTradeById(global::ServiceContract.TradeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetTradeById, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::ServiceContract.TradeResult> GetTradeByIdAsync(global::ServiceContract.TradeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetTradeByIdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::ServiceContract.TradeResult> GetTradeByIdAsync(global::ServiceContract.TradeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetTradeById, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override TradeServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new TradeServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(TradeServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAllTradesStream, serviceImpl.GetAllTradesStream)
          .AddMethod(__Method_GetTradeById, serviceImpl.GetTradeById).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, TradeServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAllTradesStream, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::ServiceContract.TradeRequest, global::ServiceContract.TradeResult>(serviceImpl.GetAllTradesStream));
      serviceBinder.AddMethod(__Method_GetTradeById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ServiceContract.TradeRequest, global::ServiceContract.TradeResult>(serviceImpl.GetTradeById));
    }

  }
}
#endregion
