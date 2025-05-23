// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class CanonicalProfileDefinition : IUtf8JsonSerializable, IJsonModel<CanonicalProfileDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CanonicalProfileDefinition>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CanonicalProfileDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CanonicalProfileDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CanonicalProfileDefinition)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(CanonicalProfileId))
            {
                writer.WritePropertyName("canonicalProfileId"u8);
                writer.WriteNumberValue(CanonicalProfileId.Value);
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteStartArray();
                foreach (var item in Properties)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        CanonicalProfileDefinition IJsonModel<CanonicalProfileDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CanonicalProfileDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CanonicalProfileDefinition)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCanonicalProfileDefinition(document.RootElement, options);
        }

        internal static CanonicalProfileDefinition DeserializeCanonicalProfileDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? canonicalProfileId = default;
            IReadOnlyList<CanonicalProfileDefinitionPropertiesItem> properties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("canonicalProfileId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    canonicalProfileId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CanonicalProfileDefinitionPropertiesItem> array = new List<CanonicalProfileDefinitionPropertiesItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CanonicalProfileDefinitionPropertiesItem.DeserializeCanonicalProfileDefinitionPropertiesItem(item, options));
                    }
                    properties = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CanonicalProfileDefinition(canonicalProfileId, properties ?? new ChangeTrackingList<CanonicalProfileDefinitionPropertiesItem>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CanonicalProfileDefinition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CanonicalProfileDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerCustomerInsightsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(CanonicalProfileDefinition)} does not support writing '{options.Format}' format.");
            }
        }

        CanonicalProfileDefinition IPersistableModel<CanonicalProfileDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CanonicalProfileDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCanonicalProfileDefinition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CanonicalProfileDefinition)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CanonicalProfileDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
