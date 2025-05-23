// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Confluent.Models
{
    public partial class MetadataEntity : IUtf8JsonSerializable, IJsonModel<MetadataEntity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MetadataEntity>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MetadataEntity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetadataEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MetadataEntity)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Self))
            {
                writer.WritePropertyName("self"u8);
                writer.WriteStringValue(Self);
            }
            if (Optional.IsDefined(ResourceName))
            {
                writer.WritePropertyName("resource_name"u8);
                writer.WriteStringValue(ResourceName);
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("created_at"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(UpdatedOn))
            {
                writer.WritePropertyName("updated_at"u8);
                writer.WriteStringValue(UpdatedOn.Value, "O");
            }
            if (Optional.IsDefined(DeletedOn))
            {
                writer.WritePropertyName("deleted_at"u8);
                writer.WriteStringValue(DeletedOn.Value, "O");
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

        MetadataEntity IJsonModel<MetadataEntity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetadataEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MetadataEntity)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMetadataEntity(document.RootElement, options);
        }

        internal static MetadataEntity DeserializeMetadataEntity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string self = default;
            string resourceName = default;
            DateTimeOffset? createdAt = default;
            DateTimeOffset? updatedAt = default;
            DateTimeOffset? deletedAt = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("self"u8))
                {
                    self = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resource_name"u8))
                {
                    resourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("created_at"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("updated_at"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updatedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("deleted_at"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deletedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MetadataEntity(
                self,
                resourceName,
                createdAt,
                updatedAt,
                deletedAt,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MetadataEntity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetadataEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerConfluentContext.Default);
                default:
                    throw new FormatException($"The model {nameof(MetadataEntity)} does not support writing '{options.Format}' format.");
            }
        }

        MetadataEntity IPersistableModel<MetadataEntity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetadataEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMetadataEntity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MetadataEntity)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MetadataEntity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
