// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class ProxyArtifactOverviewPropertiesValue : IUtf8JsonSerializable, IJsonModel<ProxyArtifactOverviewPropertiesValue>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProxyArtifactOverviewPropertiesValue>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ProxyArtifactOverviewPropertiesValue>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProxyArtifactOverviewPropertiesValue>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProxyArtifactOverviewPropertiesValue)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ArtifactType))
            {
                writer.WritePropertyName("artifactType"u8);
                writer.WriteStringValue(ArtifactType.Value.ToString());
            }
            if (Optional.IsDefined(ArtifactVersion))
            {
                writer.WritePropertyName("artifactVersion"u8);
                writer.WriteStringValue(ArtifactVersion);
            }
            if (Optional.IsDefined(ArtifactState))
            {
                writer.WritePropertyName("artifactState"u8);
                writer.WriteStringValue(ArtifactState.Value.ToString());
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

        ProxyArtifactOverviewPropertiesValue IJsonModel<ProxyArtifactOverviewPropertiesValue>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProxyArtifactOverviewPropertiesValue>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProxyArtifactOverviewPropertiesValue)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProxyArtifactOverviewPropertiesValue(document.RootElement, options);
        }

        internal static ProxyArtifactOverviewPropertiesValue DeserializeProxyArtifactOverviewPropertiesValue(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ArtifactType? artifactType = default;
            string artifactVersion = default;
            ArtifactState? artifactState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("artifactType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    artifactType = new ArtifactType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("artifactVersion"u8))
                {
                    artifactVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("artifactState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    artifactState = new ArtifactState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ProxyArtifactOverviewPropertiesValue(artifactType, artifactVersion, artifactState, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ProxyArtifactOverviewPropertiesValue>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProxyArtifactOverviewPropertiesValue>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerHybridNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ProxyArtifactOverviewPropertiesValue)} does not support writing '{options.Format}' format.");
            }
        }

        ProxyArtifactOverviewPropertiesValue IPersistableModel<ProxyArtifactOverviewPropertiesValue>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProxyArtifactOverviewPropertiesValue>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeProxyArtifactOverviewPropertiesValue(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProxyArtifactOverviewPropertiesValue)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProxyArtifactOverviewPropertiesValue>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
