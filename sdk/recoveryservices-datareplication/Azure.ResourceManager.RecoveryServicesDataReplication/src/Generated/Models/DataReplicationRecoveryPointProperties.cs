// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> Recovery point model properties. </summary>
    public partial class DataReplicationRecoveryPointProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataReplicationRecoveryPointProperties"/>. </summary>
        /// <param name="recoveryPointOn"> Gets or sets the recovery point time. </param>
        /// <param name="recoveryPointType"> Gets or sets the recovery point type. </param>
        /// <param name="customProperties">
        /// Recovery point model custom properties.
        /// Please note <see cref="DataReplicationRecoveryPointCustomProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="HyperVToAzStackHciRecoveryPointCustomProperties"/> and <see cref="VMwareToAzStackHciRecoveryPointCustomProperties"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customProperties"/> is null. </exception>
        internal DataReplicationRecoveryPointProperties(DateTimeOffset recoveryPointOn, DataReplicationRecoveryPointType recoveryPointType, DataReplicationRecoveryPointCustomProperties customProperties)
        {
            Argument.AssertNotNull(customProperties, nameof(customProperties));

            RecoveryPointOn = recoveryPointOn;
            RecoveryPointType = recoveryPointType;
            CustomProperties = customProperties;
        }

        /// <summary> Initializes a new instance of <see cref="DataReplicationRecoveryPointProperties"/>. </summary>
        /// <param name="recoveryPointOn"> Gets or sets the recovery point time. </param>
        /// <param name="recoveryPointType"> Gets or sets the recovery point type. </param>
        /// <param name="customProperties">
        /// Recovery point model custom properties.
        /// Please note <see cref="DataReplicationRecoveryPointCustomProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="HyperVToAzStackHciRecoveryPointCustomProperties"/> and <see cref="VMwareToAzStackHciRecoveryPointCustomProperties"/>.
        /// </param>
        /// <param name="provisioningState"> Gets or sets the provisioning state of the recovery point item. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataReplicationRecoveryPointProperties(DateTimeOffset recoveryPointOn, DataReplicationRecoveryPointType recoveryPointType, DataReplicationRecoveryPointCustomProperties customProperties, DataReplicationProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RecoveryPointOn = recoveryPointOn;
            RecoveryPointType = recoveryPointType;
            CustomProperties = customProperties;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataReplicationRecoveryPointProperties"/> for deserialization. </summary>
        internal DataReplicationRecoveryPointProperties()
        {
        }

        /// <summary> Gets or sets the recovery point time. </summary>
        public DateTimeOffset RecoveryPointOn { get; }
        /// <summary> Gets or sets the recovery point type. </summary>
        public DataReplicationRecoveryPointType RecoveryPointType { get; }
        /// <summary>
        /// Recovery point model custom properties.
        /// Please note <see cref="DataReplicationRecoveryPointCustomProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="HyperVToAzStackHciRecoveryPointCustomProperties"/> and <see cref="VMwareToAzStackHciRecoveryPointCustomProperties"/>.
        /// </summary>
        public DataReplicationRecoveryPointCustomProperties CustomProperties { get; }
        /// <summary> Gets or sets the provisioning state of the recovery point item. </summary>
        public DataReplicationProvisioningState? ProvisioningState { get; }
    }
}
