// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.RealtimeConversation
{
    internal partial class UnknownRealtimeResponseStatusDetails : IJsonModel<ConversationStatusDetails>
    {
        internal UnknownRealtimeResponseStatusDetails()
        {
        }

        void IJsonModel<ConversationStatusDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ConversationStatusDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConversationStatusDetails)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
        }

        ConversationStatusDetails IJsonModel<ConversationStatusDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected override ConversationStatusDetails JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ConversationStatusDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConversationStatusDetails)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConversationStatusDetails(document.RootElement, options);
        }

        internal static UnknownRealtimeResponseStatusDetails DeserializeUnknownRealtimeResponseStatusDetails(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ConversationStatus statusKind = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    statusKind = new ConversationStatus(prop.Value.GetString());
                    continue;
                }
                if (true)
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new UnknownRealtimeResponseStatusDetails(statusKind, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<ConversationStatusDetails>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ConversationStatusDetails>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConversationStatusDetails)} does not support writing '{options.Format}' format.");
            }
        }

        ConversationStatusDetails IPersistableModel<ConversationStatusDetails>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected override ConversationStatusDetails PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ConversationStatusDetails>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeConversationStatusDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConversationStatusDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConversationStatusDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
