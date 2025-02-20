// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DeviceRegistry
{
    public partial class DeviceRegistrySchemaRegistryResource : IJsonModel<DeviceRegistrySchemaRegistryData>
    {
        void IJsonModel<DeviceRegistrySchemaRegistryData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DeviceRegistrySchemaRegistryData>)Data).Write(writer, options);

        DeviceRegistrySchemaRegistryData IJsonModel<DeviceRegistrySchemaRegistryData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DeviceRegistrySchemaRegistryData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<DeviceRegistrySchemaRegistryData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        DeviceRegistrySchemaRegistryData IPersistableModel<DeviceRegistrySchemaRegistryData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DeviceRegistrySchemaRegistryData>(data, options);

        string IPersistableModel<DeviceRegistrySchemaRegistryData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DeviceRegistrySchemaRegistryData>)Data).GetFormatFromOptions(options);
    }
}
