// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.ContainerInstance.Models;

namespace Azure.ResourceManager.ContainerInstance.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableContainerInstanceSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _containerGroupClientDiagnostics;
        private ContainerGroupsRestOperations _containerGroupRestClient;
        private ClientDiagnostics _locationClientDiagnostics;
        private LocationRestOperations _locationRestClient;
        private ClientDiagnostics _nGroupClientDiagnostics;
        private NGroupsRestOperations _nGroupRestClient;
        private ClientDiagnostics _containerGroupProfileCGProfilesClientDiagnostics;
        private CGProfilesRestOperations _containerGroupProfileCGProfilesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableContainerInstanceSubscriptionResource"/> class for mocking. </summary>
        protected MockableContainerInstanceSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableContainerInstanceSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableContainerInstanceSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ContainerGroupClientDiagnostics => _containerGroupClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ContainerInstance", ContainerGroupResource.ResourceType.Namespace, Diagnostics);
        private ContainerGroupsRestOperations ContainerGroupRestClient => _containerGroupRestClient ??= new ContainerGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ContainerGroupResource.ResourceType));
        private ClientDiagnostics LocationClientDiagnostics => _locationClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ContainerInstance", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private LocationRestOperations LocationRestClient => _locationRestClient ??= new LocationRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics NGroupClientDiagnostics => _nGroupClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ContainerInstance", NGroupResource.ResourceType.Namespace, Diagnostics);
        private NGroupsRestOperations NGroupRestClient => _nGroupRestClient ??= new NGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(NGroupResource.ResourceType));
        private ClientDiagnostics ContainerGroupProfileCGProfilesClientDiagnostics => _containerGroupProfileCGProfilesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ContainerInstance", ContainerGroupProfileResource.ResourceType.Namespace, Diagnostics);
        private CGProfilesRestOperations ContainerGroupProfileCGProfilesRestClient => _containerGroupProfileCGProfilesRestClient ??= new CGProfilesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ContainerGroupProfileResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Get a list of container groups in the specified subscription. This operation returns properties of each container group including containers, image registry credentials, restart policy, IP address type, OS type, state, and volumes.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerInstance/containerGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerGroups_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerGroupResource> GetContainerGroupsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ContainerGroupRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ContainerGroupRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ContainerGroupResource(Client, ContainerGroupData.DeserializeContainerGroupData(e)), ContainerGroupClientDiagnostics, Pipeline, "MockableContainerInstanceSubscriptionResource.GetContainerGroups", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of container groups in the specified subscription. This operation returns properties of each container group including containers, image registry credentials, restart policy, IP address type, OS type, state, and volumes.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerInstance/containerGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerGroups_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerGroupResource> GetContainerGroups(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ContainerGroupRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ContainerGroupRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ContainerGroupResource(Client, ContainerGroupData.DeserializeContainerGroupData(e)), ContainerGroupClientDiagnostics, Pipeline, "MockableContainerInstanceSubscriptionResource.GetContainerGroups", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the usage for a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerInstance/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Location_ListUsage</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerInstanceUsage"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerInstanceUsage> GetUsagesWithLocationAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => LocationRestClient.CreateListUsageRequest(Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => ContainerInstanceUsage.DeserializeContainerInstanceUsage(e), LocationClientDiagnostics, Pipeline, "MockableContainerInstanceSubscriptionResource.GetUsagesWithLocation", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get the usage for a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerInstance/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Location_ListUsage</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerInstanceUsage"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerInstanceUsage> GetUsagesWithLocation(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => LocationRestClient.CreateListUsageRequest(Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => ContainerInstanceUsage.DeserializeContainerInstanceUsage(e), LocationClientDiagnostics, Pipeline, "MockableContainerInstanceSubscriptionResource.GetUsagesWithLocation", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get the list of cached images on specific OS type for a subscription in a region.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerInstance/locations/{location}/cachedImages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Location_ListCachedImages</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CachedImages"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CachedImages> GetCachedImagesWithLocationAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => LocationRestClient.CreateListCachedImagesRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => LocationRestClient.CreateListCachedImagesNextPageRequest(nextLink, Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => CachedImages.DeserializeCachedImages(e), LocationClientDiagnostics, Pipeline, "MockableContainerInstanceSubscriptionResource.GetCachedImagesWithLocation", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the list of cached images on specific OS type for a subscription in a region.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerInstance/locations/{location}/cachedImages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Location_ListCachedImages</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CachedImages"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CachedImages> GetCachedImagesWithLocation(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => LocationRestClient.CreateListCachedImagesRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => LocationRestClient.CreateListCachedImagesNextPageRequest(nextLink, Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => CachedImages.DeserializeCachedImages(e), LocationClientDiagnostics, Pipeline, "MockableContainerInstanceSubscriptionResource.GetCachedImagesWithLocation", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the list of CPU/memory/GPU capabilities of a region.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerInstance/locations/{location}/capabilities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Location_ListCapabilities</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerCapabilities"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerCapabilities> GetCapabilitiesWithLocationAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => LocationRestClient.CreateListCapabilitiesRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => LocationRestClient.CreateListCapabilitiesNextPageRequest(nextLink, Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => ContainerCapabilities.DeserializeContainerCapabilities(e), LocationClientDiagnostics, Pipeline, "MockableContainerInstanceSubscriptionResource.GetCapabilitiesWithLocation", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the list of CPU/memory/GPU capabilities of a region.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerInstance/locations/{location}/capabilities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Location_ListCapabilities</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerCapabilities"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerCapabilities> GetCapabilitiesWithLocation(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => LocationRestClient.CreateListCapabilitiesRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => LocationRestClient.CreateListCapabilitiesNextPageRequest(nextLink, Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => ContainerCapabilities.DeserializeContainerCapabilities(e), LocationClientDiagnostics, Pipeline, "MockableContainerInstanceSubscriptionResource.GetCapabilitiesWithLocation", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of all NGroups resources under a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerInstance/ngroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NGroups_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NGroupResource> GetNGroupsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => NGroupRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => NGroupRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NGroupResource(Client, NGroupData.DeserializeNGroupData(e)), NGroupClientDiagnostics, Pipeline, "MockableContainerInstanceSubscriptionResource.GetNGroups", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of all NGroups resources under a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerInstance/ngroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NGroups_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NGroupResource> GetNGroups(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => NGroupRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => NGroupRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NGroupResource(Client, NGroupData.DeserializeNGroupData(e)), NGroupClientDiagnostics, Pipeline, "MockableContainerInstanceSubscriptionResource.GetNGroups", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of all container group profiles under a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerInstance/containerGroupProfiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CGProfiles_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerGroupProfileResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerGroupProfileResource> GetContainerGroupProfilesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ContainerGroupProfileCGProfilesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ContainerGroupProfileCGProfilesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ContainerGroupProfileResource(Client, ContainerGroupProfileData.DeserializeContainerGroupProfileData(e)), ContainerGroupProfileCGProfilesClientDiagnostics, Pipeline, "MockableContainerInstanceSubscriptionResource.GetContainerGroupProfiles", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of all container group profiles under a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerInstance/containerGroupProfiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CGProfiles_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerGroupProfileResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerGroupProfileResource> GetContainerGroupProfiles(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ContainerGroupProfileCGProfilesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ContainerGroupProfileCGProfilesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ContainerGroupProfileResource(Client, ContainerGroupProfileData.DeserializeContainerGroupProfileData(e)), ContainerGroupProfileCGProfilesClientDiagnostics, Pipeline, "MockableContainerInstanceSubscriptionResource.GetContainerGroupProfiles", "value", "nextLink", cancellationToken);
        }
    }
}
