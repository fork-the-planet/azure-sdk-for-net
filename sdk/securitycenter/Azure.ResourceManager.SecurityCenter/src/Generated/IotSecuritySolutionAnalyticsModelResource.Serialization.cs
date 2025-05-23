// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class IotSecuritySolutionAnalyticsModelResource : IJsonModel<IotSecuritySolutionAnalyticsModelData>
    {
        private static IotSecuritySolutionAnalyticsModelData s_dataDeserializationInstance;
        private static IotSecuritySolutionAnalyticsModelData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<IotSecuritySolutionAnalyticsModelData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<IotSecuritySolutionAnalyticsModelData>)Data).Write(writer, options);

        IotSecuritySolutionAnalyticsModelData IJsonModel<IotSecuritySolutionAnalyticsModelData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<IotSecuritySolutionAnalyticsModelData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<IotSecuritySolutionAnalyticsModelData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<IotSecuritySolutionAnalyticsModelData>(Data, options, AzureResourceManagerSecurityCenterContext.Default);

        IotSecuritySolutionAnalyticsModelData IPersistableModel<IotSecuritySolutionAnalyticsModelData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<IotSecuritySolutionAnalyticsModelData>(data, options, AzureResourceManagerSecurityCenterContext.Default);

        string IPersistableModel<IotSecuritySolutionAnalyticsModelData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<IotSecuritySolutionAnalyticsModelData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
