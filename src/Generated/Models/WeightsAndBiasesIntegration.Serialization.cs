// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.FineTuning
{
    internal partial class WeightsAndBiasesIntegration : IJsonModel<WeightsAndBiasesIntegration>
    {
        internal WeightsAndBiasesIntegration()
        {
        }

        void IJsonModel<WeightsAndBiasesIntegration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<WeightsAndBiasesIntegration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WeightsAndBiasesIntegration)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("wandb") != true)
            {
                writer.WritePropertyName("wandb"u8);
                writer.WriteObjectValue(Wandb, options);
            }
        }

        WeightsAndBiasesIntegration IJsonModel<WeightsAndBiasesIntegration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (WeightsAndBiasesIntegration)JsonModelCreateCore(ref reader, options);

        protected override FineTuningIntegration JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<WeightsAndBiasesIntegration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WeightsAndBiasesIntegration)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWeightsAndBiasesIntegration(document.RootElement, options);
        }

        internal static WeightsAndBiasesIntegration DeserializeWeightsAndBiasesIntegration(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string @type = "wandb";
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            InternalCreateFineTuningJobRequestWandbIntegrationWandb wandb = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    @type = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("wandb"u8))
                {
                    wandb = InternalCreateFineTuningJobRequestWandbIntegrationWandb.DeserializeInternalCreateFineTuningJobRequestWandbIntegrationWandb(prop.Value, options);
                    continue;
                }
                if (true)
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new WeightsAndBiasesIntegration(@type, additionalBinaryDataProperties, wandb);
        }

        BinaryData IPersistableModel<WeightsAndBiasesIntegration>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<WeightsAndBiasesIntegration>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WeightsAndBiasesIntegration)} does not support writing '{options.Format}' format.");
            }
        }

        WeightsAndBiasesIntegration IPersistableModel<WeightsAndBiasesIntegration>.Create(BinaryData data, ModelReaderWriterOptions options) => (WeightsAndBiasesIntegration)PersistableModelCreateCore(data, options);

        protected override FineTuningIntegration PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<WeightsAndBiasesIntegration>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeWeightsAndBiasesIntegration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WeightsAndBiasesIntegration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WeightsAndBiasesIntegration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(WeightsAndBiasesIntegration weightsAndBiasesIntegration)
        {
            if (weightsAndBiasesIntegration == null)
            {
                return null;
            }
            return BinaryContent.Create(weightsAndBiasesIntegration, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator WeightsAndBiasesIntegration(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeWeightsAndBiasesIntegration(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
