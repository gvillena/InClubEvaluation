// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/catalog.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace CatalogApi {
  public static partial class Catalog
  {
    static readonly string __ServiceName = "CatalogApi.Catalog";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CatalogApi.CatalogItemRequest> __Marshaller_CatalogApi_CatalogItemRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CatalogApi.CatalogItemRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CatalogApi.CatalogItemResponse> __Marshaller_CatalogApi_CatalogItemResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CatalogApi.CatalogItemResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CatalogApi.CatalogItemsRequest> __Marshaller_CatalogApi_CatalogItemsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CatalogApi.CatalogItemsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CatalogApi.PaginatedItemsResponse> __Marshaller_CatalogApi_PaginatedItemsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CatalogApi.PaginatedItemsResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CatalogApi.CatalogItemRequest, global::CatalogApi.CatalogItemResponse> __Method_GetItemById = new grpc::Method<global::CatalogApi.CatalogItemRequest, global::CatalogApi.CatalogItemResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetItemById",
        __Marshaller_CatalogApi_CatalogItemRequest,
        __Marshaller_CatalogApi_CatalogItemResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CatalogApi.CatalogItemsRequest, global::CatalogApi.PaginatedItemsResponse> __Method_GetItemsByIds = new grpc::Method<global::CatalogApi.CatalogItemsRequest, global::CatalogApi.PaginatedItemsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetItemsByIds",
        __Marshaller_CatalogApi_CatalogItemsRequest,
        __Marshaller_CatalogApi_PaginatedItemsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::CatalogApi.CatalogReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Catalog</summary>
    [grpc::BindServiceMethod(typeof(Catalog), "BindService")]
    public abstract partial class CatalogBase
    {
      /// <summary>
      /// >>
      ///option (google.api.http) = {
      ///get: "/api/v1/catalog/items/{id}"
      ///};
      ///&lt;&lt; 
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::CatalogApi.CatalogItemResponse> GetItemById(global::CatalogApi.CatalogItemRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::CatalogApi.PaginatedItemsResponse> GetItemsByIds(global::CatalogApi.CatalogItemsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(CatalogBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetItemById, serviceImpl.GetItemById)
          .AddMethod(__Method_GetItemsByIds, serviceImpl.GetItemsByIds).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CatalogBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetItemById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CatalogApi.CatalogItemRequest, global::CatalogApi.CatalogItemResponse>(serviceImpl.GetItemById));
      serviceBinder.AddMethod(__Method_GetItemsByIds, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CatalogApi.CatalogItemsRequest, global::CatalogApi.PaginatedItemsResponse>(serviceImpl.GetItemsByIds));
    }

  }
}
#endregion
