// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Images
{
    public partial class ImageGenerationOptions : IJsonModel<ImageGenerationOptions>
    {
        void IJsonModel<ImageGenerationOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageGenerationOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageGenerationOptions)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (SerializedAdditionalRawData?.ContainsKey("prompt") != true)
            {
                writer.WritePropertyName("prompt"u8);
                writer.WriteStringValue(Prompt);
            }
            if (SerializedAdditionalRawData?.ContainsKey("model") != true && Optional.IsDefined(Model))
            {
                if (Model != null)
                {
                    writer.WritePropertyName("model"u8);
                    writer.WriteStringValue(Model.Value.ToString());
                }
                else
                {
                    writer.WriteNull("model");
                }
            }
            if (SerializedAdditionalRawData?.ContainsKey("n") != true && Optional.IsDefined(N))
            {
                if (N != null)
                {
                    writer.WritePropertyName("n"u8);
                    writer.WriteNumberValue(N.Value);
                }
                else
                {
                    writer.WriteNull("n");
                }
            }
            if (SerializedAdditionalRawData?.ContainsKey("quality") != true && Optional.IsDefined(Quality))
            {
                writer.WritePropertyName("quality"u8);
                writer.WriteStringValue(Quality.Value.ToSerialString());
            }
            if (SerializedAdditionalRawData?.ContainsKey("response_format") != true && Optional.IsDefined(ResponseFormat))
            {
                if (ResponseFormat != null)
                {
                    writer.WritePropertyName("response_format"u8);
                    writer.WriteStringValue(ResponseFormat.Value.ToSerialString());
                }
                else
                {
                    writer.WriteNull("response_format");
                }
            }
            if (SerializedAdditionalRawData?.ContainsKey("size") != true && Optional.IsDefined(Size))
            {
                if (Size != null)
                {
                    writer.WritePropertyName("size"u8);
                    writer.WriteStringValue(Size.Value.ToString());
                }
                else
                {
                    writer.WriteNull("size");
                }
            }
            if (SerializedAdditionalRawData?.ContainsKey("style") != true && Optional.IsDefined(Style))
            {
                if (Style != null)
                {
                    writer.WritePropertyName("style"u8);
                    writer.WriteStringValue(Style.Value.ToSerialString());
                }
                else
                {
                    writer.WriteNull("style");
                }
            }
            if (SerializedAdditionalRawData?.ContainsKey("user") != true && Optional.IsDefined(User))
            {
                writer.WritePropertyName("user"u8);
                writer.WriteStringValue(User);
            }
            if (SerializedAdditionalRawData != null)
            {
                foreach (var item in SerializedAdditionalRawData)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ImageGenerationOptions IJsonModel<ImageGenerationOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageGenerationOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageGenerationOptions)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeImageGenerationOptions(document.RootElement, options);
        }

        internal static ImageGenerationOptions DeserializeImageGenerationOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string prompt = default;
            InternalCreateImageRequestModel? model = default;
            long? n = default;
            GeneratedImageQuality? quality = default;
            GeneratedImageFormat? responseFormat = default;
            GeneratedImageSize? size = default;
            GeneratedImageStyle? style = default;
            string user = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("prompt"u8))
                {
                    prompt = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("model"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        model = null;
                        continue;
                    }
                    model = new InternalCreateImageRequestModel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("n"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        n = null;
                        continue;
                    }
                    n = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("quality"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    quality = property.Value.GetString().ToGeneratedImageQuality();
                    continue;
                }
                if (property.NameEquals("response_format"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        responseFormat = null;
                        continue;
                    }
                    responseFormat = property.Value.GetString().ToGeneratedImageFormat();
                    continue;
                }
                if (property.NameEquals("size"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        size = null;
                        continue;
                    }
                    size = new GeneratedImageSize(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("style"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        style = null;
                        continue;
                    }
                    style = property.Value.GetString().ToGeneratedImageStyle();
                    continue;
                }
                if (property.NameEquals("user"u8))
                {
                    user = property.Value.GetString();
                    continue;
                }
                if (true)
                {
                    rawDataDictionary ??= new Dictionary<string, BinaryData>();
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ImageGenerationOptions(
                prompt,
                model,
                n,
                quality,
                responseFormat,
                size,
                style,
                user,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ImageGenerationOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageGenerationOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ImageGenerationOptions)} does not support writing '{options.Format}' format.");
            }
        }

        ImageGenerationOptions IPersistableModel<ImageGenerationOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageGenerationOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeImageGenerationOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ImageGenerationOptions)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ImageGenerationOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static ImageGenerationOptions FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeImageGenerationOptions(document.RootElement);
        }

        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
