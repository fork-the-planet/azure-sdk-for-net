// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Quota
{
    public partial class CurrentQuotaLimitBaseResource : IJsonModel<CurrentQuotaLimitBaseData>
    {
        private static CurrentQuotaLimitBaseData s_dataDeserializationInstance;
        private static CurrentQuotaLimitBaseData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<CurrentQuotaLimitBaseData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<CurrentQuotaLimitBaseData>)Data).Write(writer, options);

        CurrentQuotaLimitBaseData IJsonModel<CurrentQuotaLimitBaseData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<CurrentQuotaLimitBaseData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<CurrentQuotaLimitBaseData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<CurrentQuotaLimitBaseData>(Data, options, AzureResourceManagerQuotaContext.Default);

        CurrentQuotaLimitBaseData IPersistableModel<CurrentQuotaLimitBaseData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<CurrentQuotaLimitBaseData>(data, options, AzureResourceManagerQuotaContext.Default);

        string IPersistableModel<CurrentQuotaLimitBaseData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<CurrentQuotaLimitBaseData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
