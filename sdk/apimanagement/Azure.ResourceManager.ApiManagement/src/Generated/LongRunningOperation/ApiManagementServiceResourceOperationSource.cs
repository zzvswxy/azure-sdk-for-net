// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ApiManagement
{
    internal class ApiManagementServiceResourceOperationSource : IOperationSource<ApiManagementServiceResource>
    {
        private readonly ArmClient _client;

        internal ApiManagementServiceResourceOperationSource(ArmClient client)
        {
            _client = client;
        }

        ApiManagementServiceResource IOperationSource<ApiManagementServiceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ApiManagementServiceResourceData.DeserializeApiManagementServiceResourceData(document.RootElement);
            return new ApiManagementServiceResource(_client, data);
        }

        async ValueTask<ApiManagementServiceResource> IOperationSource<ApiManagementServiceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ApiManagementServiceResourceData.DeserializeApiManagementServiceResourceData(document.RootElement);
            return new ApiManagementServiceResource(_client, data);
        }
    }
}
