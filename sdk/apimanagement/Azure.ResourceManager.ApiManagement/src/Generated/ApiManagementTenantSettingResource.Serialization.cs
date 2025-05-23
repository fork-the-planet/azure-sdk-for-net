// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class ApiManagementTenantSettingResource : IJsonModel<ApiManagementTenantSettingData>
    {
        private static ApiManagementTenantSettingData s_dataDeserializationInstance;
        private static ApiManagementTenantSettingData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<ApiManagementTenantSettingData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ApiManagementTenantSettingData>)Data).Write(writer, options);

        ApiManagementTenantSettingData IJsonModel<ApiManagementTenantSettingData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ApiManagementTenantSettingData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<ApiManagementTenantSettingData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<ApiManagementTenantSettingData>(Data, options, AzureResourceManagerApiManagementContext.Default);

        ApiManagementTenantSettingData IPersistableModel<ApiManagementTenantSettingData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ApiManagementTenantSettingData>(data, options, AzureResourceManagerApiManagementContext.Default);

        string IPersistableModel<ApiManagementTenantSettingData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ApiManagementTenantSettingData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
