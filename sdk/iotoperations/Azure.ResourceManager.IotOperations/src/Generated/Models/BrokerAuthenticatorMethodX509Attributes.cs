// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.IotOperations.Models
{
    /// <summary> BrokerAuthenticatorMethodX509Attributes properties. </summary>
    public partial class BrokerAuthenticatorMethodX509Attributes
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

        /// <summary> Initializes a new instance of <see cref="BrokerAuthenticatorMethodX509Attributes"/>. </summary>
        /// <param name="attributes"> Attributes object. </param>
        /// <param name="subject"> Subject of the X509 attribute. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="attributes"/> or <paramref name="subject"/> is null. </exception>
        public BrokerAuthenticatorMethodX509Attributes(IDictionary<string, string> attributes, string subject)
        {
            Argument.AssertNotNull(attributes, nameof(attributes));
            Argument.AssertNotNull(subject, nameof(subject));

            Attributes = attributes;
            Subject = subject;
        }

        /// <summary> Initializes a new instance of <see cref="BrokerAuthenticatorMethodX509Attributes"/>. </summary>
        /// <param name="attributes"> Attributes object. </param>
        /// <param name="subject"> Subject of the X509 attribute. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BrokerAuthenticatorMethodX509Attributes(IDictionary<string, string> attributes, string subject, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Attributes = attributes;
            Subject = subject;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BrokerAuthenticatorMethodX509Attributes"/> for deserialization. </summary>
        internal BrokerAuthenticatorMethodX509Attributes()
        {
        }

        /// <summary> Attributes object. </summary>
        public IDictionary<string, string> Attributes { get; }
        /// <summary> Subject of the X509 attribute. </summary>
        public string Subject { get; set; }
    }
}
