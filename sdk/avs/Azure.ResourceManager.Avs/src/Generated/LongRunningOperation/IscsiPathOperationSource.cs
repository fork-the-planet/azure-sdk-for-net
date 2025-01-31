// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Avs
{
    internal class IscsiPathOperationSource : IOperationSource<IscsiPathResource>
    {
        private readonly ArmClient _client;

        internal IscsiPathOperationSource(ArmClient client)
        {
            _client = client;
        }

        IscsiPathResource IOperationSource<IscsiPathResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = IscsiPathData.DeserializeIscsiPathData(document.RootElement);
            return new IscsiPathResource(_client, data);
        }

        async ValueTask<IscsiPathResource> IOperationSource<IscsiPathResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = IscsiPathData.DeserializeIscsiPathData(document.RootElement);
            return new IscsiPathResource(_client, data);
        }
    }
}
