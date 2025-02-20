// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.ManagementGroups;

namespace Azure.ResourceManager.Quota
{
    /// <summary>
    /// A class representing a collection of <see cref="QuotaAllocationRequestStatusResource"/> and their operations.
    /// Each <see cref="QuotaAllocationRequestStatusResource"/> in the collection will belong to the same instance of <see cref="ManagementGroupResource"/>.
    /// To get a <see cref="QuotaAllocationRequestStatusCollection"/> instance call the GetQuotaAllocationRequestStatuses method from an instance of <see cref="ManagementGroupResource"/>.
    /// </summary>
    public partial class QuotaAllocationRequestStatusCollection : ArmCollection
    {
        private readonly ClientDiagnostics _quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestClientDiagnostics;
        private readonly GroupQuotaSubscriptionAllocationRequestRestOperations _quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestRestClient;
        private readonly string _subscriptionId;
        private readonly string _groupQuotaName;
        private readonly string _resourceProviderName;

        /// <summary> Initializes a new instance of the <see cref="QuotaAllocationRequestStatusCollection"/> class for mocking. </summary>
        protected QuotaAllocationRequestStatusCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="QuotaAllocationRequestStatusCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. The name should be unique for the provided context tenantId/MgId. </param>
        /// <param name="resourceProviderName"> The resource provider name, such as - Microsoft.Compute. Currently only Microsoft.Compute resource provider supports this API. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="groupQuotaName"/> or <paramref name="resourceProviderName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="groupQuotaName"/> or <paramref name="resourceProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        internal QuotaAllocationRequestStatusCollection(ArmClient client, ResourceIdentifier id, string subscriptionId, string groupQuotaName, string resourceProviderName) : base(client, id)
        {
            _subscriptionId = subscriptionId;
            _groupQuotaName = groupQuotaName;
            _resourceProviderName = resourceProviderName;
            _quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Quota", QuotaAllocationRequestStatusResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(QuotaAllocationRequestStatusResource.ResourceType, out string quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestApiVersion);
            _quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestRestClient = new GroupQuotaSubscriptionAllocationRequestRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagementGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagementGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get the quota allocation request status for the subscriptionId by allocationId.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/subscriptions/{subscriptionId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/resourceProviders/{resourceProviderName}/quotaAllocationRequests/{allocationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupQuotaSubscriptionAllocationRequest_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="QuotaAllocationRequestStatusResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="allocationId"> Request Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="allocationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="allocationId"/> is null. </exception>
        public virtual async Task<Response<QuotaAllocationRequestStatusResource>> GetAsync(string allocationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(allocationId, nameof(allocationId));

            using var scope = _quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestClientDiagnostics.CreateScope("QuotaAllocationRequestStatusCollection.Get");
            scope.Start();
            try
            {
                var response = await _quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestRestClient.GetAsync(Id.Name, _subscriptionId, _groupQuotaName, _resourceProviderName, allocationId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new QuotaAllocationRequestStatusResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the quota allocation request status for the subscriptionId by allocationId.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/subscriptions/{subscriptionId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/resourceProviders/{resourceProviderName}/quotaAllocationRequests/{allocationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupQuotaSubscriptionAllocationRequest_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="QuotaAllocationRequestStatusResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="allocationId"> Request Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="allocationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="allocationId"/> is null. </exception>
        public virtual Response<QuotaAllocationRequestStatusResource> Get(string allocationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(allocationId, nameof(allocationId));

            using var scope = _quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestClientDiagnostics.CreateScope("QuotaAllocationRequestStatusCollection.Get");
            scope.Start();
            try
            {
                var response = _quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestRestClient.Get(Id.Name, _subscriptionId, _groupQuotaName, _resourceProviderName, allocationId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new QuotaAllocationRequestStatusResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all the quotaAllocationRequests for a resourceProvider/location. The filter paramter for location is required.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/subscriptions/{subscriptionId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/resourceProviders/{resourceProviderName}/quotaAllocationRequests</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupQuotaSubscriptionAllocationRequest_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="QuotaAllocationRequestStatusResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter">
        /// | Field | Supported operators
        /// |---------------------|------------------------
        ///
        ///  location eq {location}
        ///  Example: $filter=location eq eastus
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="filter"/> is null. </exception>
        /// <returns> An async collection of <see cref="QuotaAllocationRequestStatusResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<QuotaAllocationRequestStatusResource> GetAllAsync(string filter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(filter, nameof(filter));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestRestClient.CreateListRequest(Id.Name, _subscriptionId, _groupQuotaName, _resourceProviderName, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestRestClient.CreateListNextPageRequest(nextLink, Id.Name, _subscriptionId, _groupQuotaName, _resourceProviderName, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new QuotaAllocationRequestStatusResource(Client, QuotaAllocationRequestStatusData.DeserializeQuotaAllocationRequestStatusData(e)), _quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestClientDiagnostics, Pipeline, "QuotaAllocationRequestStatusCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get all the quotaAllocationRequests for a resourceProvider/location. The filter paramter for location is required.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/subscriptions/{subscriptionId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/resourceProviders/{resourceProviderName}/quotaAllocationRequests</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupQuotaSubscriptionAllocationRequest_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="QuotaAllocationRequestStatusResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter">
        /// | Field | Supported operators
        /// |---------------------|------------------------
        ///
        ///  location eq {location}
        ///  Example: $filter=location eq eastus
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="filter"/> is null. </exception>
        /// <returns> A collection of <see cref="QuotaAllocationRequestStatusResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<QuotaAllocationRequestStatusResource> GetAll(string filter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(filter, nameof(filter));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestRestClient.CreateListRequest(Id.Name, _subscriptionId, _groupQuotaName, _resourceProviderName, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestRestClient.CreateListNextPageRequest(nextLink, Id.Name, _subscriptionId, _groupQuotaName, _resourceProviderName, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new QuotaAllocationRequestStatusResource(Client, QuotaAllocationRequestStatusData.DeserializeQuotaAllocationRequestStatusData(e)), _quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestClientDiagnostics, Pipeline, "QuotaAllocationRequestStatusCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/subscriptions/{subscriptionId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/resourceProviders/{resourceProviderName}/quotaAllocationRequests/{allocationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupQuotaSubscriptionAllocationRequest_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="QuotaAllocationRequestStatusResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="allocationId"> Request Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="allocationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="allocationId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string allocationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(allocationId, nameof(allocationId));

            using var scope = _quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestClientDiagnostics.CreateScope("QuotaAllocationRequestStatusCollection.Exists");
            scope.Start();
            try
            {
                var response = await _quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestRestClient.GetAsync(Id.Name, _subscriptionId, _groupQuotaName, _resourceProviderName, allocationId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/subscriptions/{subscriptionId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/resourceProviders/{resourceProviderName}/quotaAllocationRequests/{allocationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupQuotaSubscriptionAllocationRequest_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="QuotaAllocationRequestStatusResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="allocationId"> Request Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="allocationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="allocationId"/> is null. </exception>
        public virtual Response<bool> Exists(string allocationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(allocationId, nameof(allocationId));

            using var scope = _quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestClientDiagnostics.CreateScope("QuotaAllocationRequestStatusCollection.Exists");
            scope.Start();
            try
            {
                var response = _quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestRestClient.Get(Id.Name, _subscriptionId, _groupQuotaName, _resourceProviderName, allocationId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/subscriptions/{subscriptionId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/resourceProviders/{resourceProviderName}/quotaAllocationRequests/{allocationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupQuotaSubscriptionAllocationRequest_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="QuotaAllocationRequestStatusResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="allocationId"> Request Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="allocationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="allocationId"/> is null. </exception>
        public virtual async Task<NullableResponse<QuotaAllocationRequestStatusResource>> GetIfExistsAsync(string allocationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(allocationId, nameof(allocationId));

            using var scope = _quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestClientDiagnostics.CreateScope("QuotaAllocationRequestStatusCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestRestClient.GetAsync(Id.Name, _subscriptionId, _groupQuotaName, _resourceProviderName, allocationId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<QuotaAllocationRequestStatusResource>(response.GetRawResponse());
                return Response.FromValue(new QuotaAllocationRequestStatusResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/subscriptions/{subscriptionId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/resourceProviders/{resourceProviderName}/quotaAllocationRequests/{allocationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupQuotaSubscriptionAllocationRequest_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="QuotaAllocationRequestStatusResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="allocationId"> Request Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="allocationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="allocationId"/> is null. </exception>
        public virtual NullableResponse<QuotaAllocationRequestStatusResource> GetIfExists(string allocationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(allocationId, nameof(allocationId));

            using var scope = _quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestClientDiagnostics.CreateScope("QuotaAllocationRequestStatusCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _quotaAllocationRequestStatusGroupQuotaSubscriptionAllocationRequestRestClient.Get(Id.Name, _subscriptionId, _groupQuotaName, _resourceProviderName, allocationId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<QuotaAllocationRequestStatusResource>(response.GetRawResponse());
                return Response.FromValue(new QuotaAllocationRequestStatusResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
