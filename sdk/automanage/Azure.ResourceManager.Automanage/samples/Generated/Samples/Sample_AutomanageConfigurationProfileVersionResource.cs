// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Automanage.Samples
{
    public partial class Sample_AutomanageConfigurationProfileVersionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAConfigurationProfileVersion()
        {
            // Generated from example definition: specification/automanage/resource-manager/Microsoft.Automanage/stable/2022-05-04/examples/getConfigurationProfileVersion.json
            // this example is just showing the usage of "ConfigurationProfilesVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomanageConfigurationProfileVersionResource created on azure
            // for more information of creating AutomanageConfigurationProfileVersionResource, please refer to the document of AutomanageConfigurationProfileVersionResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string configurationProfileName = "customConfigurationProfile";
            string versionName = "version1";
            ResourceIdentifier automanageConfigurationProfileVersionResourceId = AutomanageConfigurationProfileVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, configurationProfileName, versionName);
            AutomanageConfigurationProfileVersionResource automanageConfigurationProfileVersion = client.GetAutomanageConfigurationProfileVersionResource(automanageConfigurationProfileVersionResourceId);

            // invoke the operation
            AutomanageConfigurationProfileVersionResource result = await automanageConfigurationProfileVersion.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutomanageConfigurationProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAConfigurationProfileVersion()
        {
            // Generated from example definition: specification/automanage/resource-manager/Microsoft.Automanage/stable/2022-05-04/examples/deleteConfigurationProfileVersion.json
            // this example is just showing the usage of "ConfigurationProfilesVersions_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomanageConfigurationProfileVersionResource created on azure
            // for more information of creating AutomanageConfigurationProfileVersionResource, please refer to the document of AutomanageConfigurationProfileVersionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string configurationProfileName = "customConfigurationProfile";
            string versionName = "version1";
            ResourceIdentifier automanageConfigurationProfileVersionResourceId = AutomanageConfigurationProfileVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, configurationProfileName, versionName);
            AutomanageConfigurationProfileVersionResource automanageConfigurationProfileVersion = client.GetAutomanageConfigurationProfileVersionResource(automanageConfigurationProfileVersionResourceId);

            // invoke the operation
            await automanageConfigurationProfileVersion.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateOrUpdateConfigurationProfileVersion()
        {
            // Generated from example definition: specification/automanage/resource-manager/Microsoft.Automanage/stable/2022-05-04/examples/createOrUpdateConfigurationProfileVersion.json
            // this example is just showing the usage of "ConfigurationProfilesVersions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomanageConfigurationProfileVersionResource created on azure
            // for more information of creating AutomanageConfigurationProfileVersionResource, please refer to the document of AutomanageConfigurationProfileVersionResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string configurationProfileName = "customConfigurationProfile";
            string versionName = "version1";
            ResourceIdentifier automanageConfigurationProfileVersionResourceId = AutomanageConfigurationProfileVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, configurationProfileName, versionName);
            AutomanageConfigurationProfileVersionResource automanageConfigurationProfileVersion = client.GetAutomanageConfigurationProfileVersionResource(automanageConfigurationProfileVersionResourceId);

            // invoke the operation
            AutomanageConfigurationProfileData data = new AutomanageConfigurationProfileData(new AzureLocation("East US"))
            {
                Configuration = BinaryData.FromObjectAsJson(new Dictionary<string, object>
                {
                    ["Antimalware/Enable"] = "false",
                    ["AzureSecurityCenter/Enable"] = "true",
                    ["Backup/Enable"] = "false",
                    ["BootDiagnostics/Enable"] = "true",
                    ["ChangeTrackingAndInventory/Enable"] = "true",
                    ["GuestConfiguration/Enable"] = "true",
                    ["LogAnalytics/Enable"] = "true",
                    ["UpdateManagement/Enable"] = "true",
                    ["VMInsights/Enable"] = "true"
                }),
                Tags =
{
["Organization"] = "Administration"
},
            };
            ArmOperation<AutomanageConfigurationProfileVersionResource> lro = await automanageConfigurationProfileVersion.UpdateAsync(WaitUntil.Completed, data);
            AutomanageConfigurationProfileVersionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutomanageConfigurationProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
