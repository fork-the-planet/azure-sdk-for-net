// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Monitor
{
    internal class MonitorPrivateEndpointConnectionOperationSource : IOperationSource<MonitorPrivateEndpointConnectionResource>
    {
        private readonly ArmClient _client;

        internal MonitorPrivateEndpointConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        MonitorPrivateEndpointConnectionResource IOperationSource<MonitorPrivateEndpointConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<MonitorPrivateEndpointConnectionData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerMonitorContext.Default);
            return new MonitorPrivateEndpointConnectionResource(_client, data);
        }

        async ValueTask<MonitorPrivateEndpointConnectionResource> IOperationSource<MonitorPrivateEndpointConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<MonitorPrivateEndpointConnectionData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerMonitorContext.Default);
            return await Task.FromResult(new MonitorPrivateEndpointConnectionResource(_client, data)).ConfigureAwait(false);
        }
    }
}
