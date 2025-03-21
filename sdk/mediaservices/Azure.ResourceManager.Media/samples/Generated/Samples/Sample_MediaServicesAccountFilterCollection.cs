// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Media.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Media.Samples
{
    public partial class Sample_MediaServicesAccountFilterCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateAnAccountFilter()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/accountFilters-create.json
            // this example is just showing the usage of "AccountFilters_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this MediaServicesAccountFilterResource
            MediaServicesAccountFilterCollection collection = mediaServicesAccount.GetMediaServicesAccountFilters();

            // invoke the operation
            string filterName = "newAccountFilter";
            MediaServicesAccountFilterData data = new MediaServicesAccountFilterData
            {
                PresentationTimeRange = new PresentationTimeRange
                {
                    StartTimestamp = 0L,
                    EndTimestamp = 170000000L,
                    PresentationWindowDuration = 9223372036854775000L,
                    LiveBackoffDuration = 0L,
                    Timescale = 10000000L,
                    ForceEndTimestamp = false,
                },
                FirstQualityBitrate = 128000,
                Tracks = {new FilterTrackSelection(new FilterTrackPropertyCondition[]
{
new FilterTrackPropertyCondition(FilterTrackPropertyType.Type, "Audio", FilterTrackPropertyCompareOperation.Equal),
new FilterTrackPropertyCondition(FilterTrackPropertyType.Language, "en", FilterTrackPropertyCompareOperation.NotEqual),
new FilterTrackPropertyCondition(FilterTrackPropertyType.FourCC, "EC-3", FilterTrackPropertyCompareOperation.NotEqual)
}), new FilterTrackSelection(new FilterTrackPropertyCondition[]
{
new FilterTrackPropertyCondition(FilterTrackPropertyType.Type, "Video", FilterTrackPropertyCompareOperation.Equal),
new FilterTrackPropertyCondition(FilterTrackPropertyType.Bitrate, "3000000-5000000", FilterTrackPropertyCompareOperation.Equal)
})},
            };
            ArmOperation<MediaServicesAccountFilterResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, filterName, data);
            MediaServicesAccountFilterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MediaServicesAccountFilterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAnAccountFilterByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/accountFilters-get-by-name.json
            // this example is just showing the usage of "AccountFilters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this MediaServicesAccountFilterResource
            MediaServicesAccountFilterCollection collection = mediaServicesAccount.GetMediaServicesAccountFilters();

            // invoke the operation
            string filterName = "accountFilterWithTrack";
            MediaServicesAccountFilterResource result = await collection.GetAsync(filterName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MediaServicesAccountFilterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListAllAccountFilters()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/accountFilters-list-all.json
            // this example is just showing the usage of "AccountFilters_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this MediaServicesAccountFilterResource
            MediaServicesAccountFilterCollection collection = mediaServicesAccount.GetMediaServicesAccountFilters();

            // invoke the operation and iterate over the result
            await foreach (MediaServicesAccountFilterResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MediaServicesAccountFilterData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAnAccountFilterByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/accountFilters-get-by-name.json
            // this example is just showing the usage of "AccountFilters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this MediaServicesAccountFilterResource
            MediaServicesAccountFilterCollection collection = mediaServicesAccount.GetMediaServicesAccountFilters();

            // invoke the operation
            string filterName = "accountFilterWithTrack";
            bool result = await collection.ExistsAsync(filterName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAnAccountFilterByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/accountFilters-get-by-name.json
            // this example is just showing the usage of "AccountFilters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this MediaServicesAccountFilterResource
            MediaServicesAccountFilterCollection collection = mediaServicesAccount.GetMediaServicesAccountFilters();

            // invoke the operation
            string filterName = "accountFilterWithTrack";
            NullableResponse<MediaServicesAccountFilterResource> response = await collection.GetIfExistsAsync(filterName);
            MediaServicesAccountFilterResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MediaServicesAccountFilterData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
