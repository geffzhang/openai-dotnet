// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using OpenAI;

namespace OpenAI.RealtimeConversation
{
    internal partial class InternalRealtimeRequestMessageItem : IJsonModel<InternalRealtimeRequestMessageItem>
    {
        internal InternalRealtimeRequestMessageItem()
        {
        }

        void IJsonModel<InternalRealtimeRequestMessageItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeRequestMessageItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeRequestMessageItem)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("role") != true)
            {
                writer.WritePropertyName("role"u8);
                writer.WriteStringValue(Role.ToString());
            }
            if (Optional.IsDefined(Status) && _additionalBinaryDataProperties?.ContainsKey("status") != true)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
        }

        InternalRealtimeRequestMessageItem IJsonModel<InternalRealtimeRequestMessageItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalRealtimeRequestMessageItem)JsonModelCreateCore(ref reader, options);

        protected override ConversationItem JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeRequestMessageItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeRequestMessageItem)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalRealtimeRequestMessageItem(document.RootElement, options);
        }

        internal static InternalRealtimeRequestMessageItem DeserializeInternalRealtimeRequestMessageItem(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("role"u8, out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "system":
                        return InternalRealtimeRequestSystemMessageItem.DeserializeInternalRealtimeRequestSystemMessageItem(element, options);
                    case "user":
                        return InternalRealtimeRequestUserMessageItem.DeserializeInternalRealtimeRequestUserMessageItem(element, options);
                    case "assistant":
                        return InternalRealtimeRequestAssistantMessageItem.DeserializeInternalRealtimeRequestAssistantMessageItem(element, options);
                }
            }
            return UnknownRealtimeRequestMessageItem.DeserializeUnknownRealtimeRequestMessageItem(element, options);
        }

        BinaryData IPersistableModel<InternalRealtimeRequestMessageItem>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeRequestMessageItem>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeRequestMessageItem)} does not support writing '{options.Format}' format.");
            }
        }

        InternalRealtimeRequestMessageItem IPersistableModel<InternalRealtimeRequestMessageItem>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalRealtimeRequestMessageItem)PersistableModelCreateCore(data, options);

        protected override ConversationItem PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeRequestMessageItem>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalRealtimeRequestMessageItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeRequestMessageItem)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalRealtimeRequestMessageItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalRealtimeRequestMessageItem internalRealtimeRequestMessageItem)
        {
            if (internalRealtimeRequestMessageItem == null)
            {
                return null;
            }
            return BinaryContent.Create(internalRealtimeRequestMessageItem, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalRealtimeRequestMessageItem(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalRealtimeRequestMessageItem(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
