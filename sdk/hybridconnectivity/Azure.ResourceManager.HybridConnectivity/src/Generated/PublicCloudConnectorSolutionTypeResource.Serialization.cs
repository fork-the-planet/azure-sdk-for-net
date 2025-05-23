// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.HybridConnectivity
{
    public partial class PublicCloudConnectorSolutionTypeResource : IJsonModel<PublicCloudConnectorSolutionTypeData>
    {
        private static PublicCloudConnectorSolutionTypeData s_dataDeserializationInstance;
        private static PublicCloudConnectorSolutionTypeData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<PublicCloudConnectorSolutionTypeData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<PublicCloudConnectorSolutionTypeData>)Data).Write(writer, options);

        PublicCloudConnectorSolutionTypeData IJsonModel<PublicCloudConnectorSolutionTypeData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<PublicCloudConnectorSolutionTypeData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<PublicCloudConnectorSolutionTypeData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<PublicCloudConnectorSolutionTypeData>(Data, options, AzureResourceManagerHybridConnectivityContext.Default);

        PublicCloudConnectorSolutionTypeData IPersistableModel<PublicCloudConnectorSolutionTypeData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<PublicCloudConnectorSolutionTypeData>(data, options, AzureResourceManagerHybridConnectivityContext.Default);

        string IPersistableModel<PublicCloudConnectorSolutionTypeData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<PublicCloudConnectorSolutionTypeData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
