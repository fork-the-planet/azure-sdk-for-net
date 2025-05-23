// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    [PersistableModelProxy(typeof(UnknownMonitorComputeConfigurationBase))]
    public partial class MonitorComputeConfigurationBase : IUtf8JsonSerializable, IJsonModel<MonitorComputeConfigurationBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitorComputeConfigurationBase>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MonitorComputeConfigurationBase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorComputeConfigurationBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorComputeConfigurationBase)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("computeType"u8);
            writer.WriteStringValue(ComputeType.ToString());
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

        MonitorComputeConfigurationBase IJsonModel<MonitorComputeConfigurationBase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorComputeConfigurationBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorComputeConfigurationBase)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorComputeConfigurationBase(document.RootElement, options);
        }

        internal static MonitorComputeConfigurationBase DeserializeMonitorComputeConfigurationBase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("computeType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ServerlessSpark": return MonitorServerlessSparkCompute.DeserializeMonitorServerlessSparkCompute(element, options);
                }
            }
            return UnknownMonitorComputeConfigurationBase.DeserializeUnknownMonitorComputeConfigurationBase(element, options);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ComputeType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  computeType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  computeType: ");
                builder.AppendLine($"'{ComputeType.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MonitorComputeConfigurationBase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorComputeConfigurationBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMachineLearningContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MonitorComputeConfigurationBase)} does not support writing '{options.Format}' format.");
            }
        }

        MonitorComputeConfigurationBase IPersistableModel<MonitorComputeConfigurationBase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorComputeConfigurationBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMonitorComputeConfigurationBase(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MonitorComputeConfigurationBase)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MonitorComputeConfigurationBase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
