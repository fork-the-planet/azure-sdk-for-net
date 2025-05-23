// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SelfHelp
{
    public partial class SelfHelpTroubleshooterResource : IJsonModel<SelfHelpTroubleshooterData>
    {
        private static SelfHelpTroubleshooterData s_dataDeserializationInstance;
        private static SelfHelpTroubleshooterData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<SelfHelpTroubleshooterData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SelfHelpTroubleshooterData>)Data).Write(writer, options);

        SelfHelpTroubleshooterData IJsonModel<SelfHelpTroubleshooterData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SelfHelpTroubleshooterData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<SelfHelpTroubleshooterData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<SelfHelpTroubleshooterData>(Data, options, AzureResourceManagerSelfHelpContext.Default);

        SelfHelpTroubleshooterData IPersistableModel<SelfHelpTroubleshooterData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SelfHelpTroubleshooterData>(data, options, AzureResourceManagerSelfHelpContext.Default);

        string IPersistableModel<SelfHelpTroubleshooterData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SelfHelpTroubleshooterData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
