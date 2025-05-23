// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class IotHubImportDevicesContent : IUtf8JsonSerializable, IJsonModel<IotHubImportDevicesContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotHubImportDevicesContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IotHubImportDevicesContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubImportDevicesContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotHubImportDevicesContent)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("inputBlobContainerUri"u8);
            writer.WriteStringValue(InputBlobContainerUri.AbsoluteUri);
            writer.WritePropertyName("outputBlobContainerUri"u8);
            writer.WriteStringValue(OutputBlobContainerUri.AbsoluteUri);
            if (Optional.IsDefined(InputBlobName))
            {
                writer.WritePropertyName("inputBlobName"u8);
                writer.WriteStringValue(InputBlobName);
            }
            if (Optional.IsDefined(OutputBlobName))
            {
                writer.WritePropertyName("outputBlobName"u8);
                writer.WriteStringValue(OutputBlobName);
            }
            if (Optional.IsDefined(AuthenticationType))
            {
                writer.WritePropertyName("authenticationType"u8);
                writer.WriteStringValue(AuthenticationType.Value.ToString());
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                writer.WriteObjectValue(Identity, options);
            }
            if (Optional.IsDefined(IncludeConfigurations))
            {
                writer.WritePropertyName("includeConfigurations"u8);
                writer.WriteBooleanValue(IncludeConfigurations.Value);
            }
            if (Optional.IsDefined(ConfigurationsBlobName))
            {
                writer.WritePropertyName("configurationsBlobName"u8);
                writer.WriteStringValue(ConfigurationsBlobName);
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

        IotHubImportDevicesContent IJsonModel<IotHubImportDevicesContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubImportDevicesContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotHubImportDevicesContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotHubImportDevicesContent(document.RootElement, options);
        }

        internal static IotHubImportDevicesContent DeserializeIotHubImportDevicesContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri inputBlobContainerUri = default;
            Uri outputBlobContainerUri = default;
            string inputBlobName = default;
            string outputBlobName = default;
            IotHubAuthenticationType? authenticationType = default;
            ManagedIdentity identity = default;
            bool? includeConfigurations = default;
            string configurationsBlobName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("inputBlobContainerUri"u8))
                {
                    inputBlobContainerUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("outputBlobContainerUri"u8))
                {
                    outputBlobContainerUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("inputBlobName"u8))
                {
                    inputBlobName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("outputBlobName"u8))
                {
                    outputBlobName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authenticationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationType = new IotHubAuthenticationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = ManagedIdentity.DeserializeManagedIdentity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("includeConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    includeConfigurations = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("configurationsBlobName"u8))
                {
                    configurationsBlobName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IotHubImportDevicesContent(
                inputBlobContainerUri,
                outputBlobContainerUri,
                inputBlobName,
                outputBlobName,
                authenticationType,
                identity,
                includeConfigurations,
                configurationsBlobName,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IotHubImportDevicesContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubImportDevicesContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerIotHubContext.Default);
                default:
                    throw new FormatException($"The model {nameof(IotHubImportDevicesContent)} does not support writing '{options.Format}' format.");
            }
        }

        IotHubImportDevicesContent IPersistableModel<IotHubImportDevicesContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubImportDevicesContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeIotHubImportDevicesContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IotHubImportDevicesContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IotHubImportDevicesContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
