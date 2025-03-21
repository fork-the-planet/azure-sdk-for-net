// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(SignalRServiceClientConnectionDisconnectedEventDataConverter))]
    public partial class SignalRServiceClientConnectionDisconnectedEventData
    {
        internal static SignalRServiceClientConnectionDisconnectedEventData DeserializeSignalRServiceClientConnectionDisconnectedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? timestamp = default;
            string hubName = default;
            string connectionId = default;
            string userId = default;
            string errorMessage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("hubName"u8))
                {
                    hubName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectionId"u8))
                {
                    connectionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userId"u8))
                {
                    userId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
            }
            return new SignalRServiceClientConnectionDisconnectedEventData(timestamp, hubName, connectionId, userId, errorMessage);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SignalRServiceClientConnectionDisconnectedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeSignalRServiceClientConnectionDisconnectedEventData(document.RootElement);
        }

        internal partial class SignalRServiceClientConnectionDisconnectedEventDataConverter : JsonConverter<SignalRServiceClientConnectionDisconnectedEventData>
        {
            public override void Write(Utf8JsonWriter writer, SignalRServiceClientConnectionDisconnectedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override SignalRServiceClientConnectionDisconnectedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSignalRServiceClientConnectionDisconnectedEventData(document.RootElement);
            }
        }
    }
}
