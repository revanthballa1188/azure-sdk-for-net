// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;
using Azure.Core;
using Azure.ResourceManager.HardwareSecurityModules;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HardwareSecurityModules.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmHardwareSecurityModulesModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="HardwareSecurityModules.CloudHsmClusterData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> The Cloud HSM Cluster's provisioningState. </param>
        /// <param name="autoGeneratedDomainNameLabelScope"> The Cloud HSM Cluster's auto-generated Domain Name Label Scope. </param>
        /// <param name="securityDomain"> Security domain properties information for Cloud HSM cluster. </param>
        /// <param name="hsms"> An array of Cloud HSM Cluster's HSMs. </param>
        /// <param name="publicNetworkAccess"> The Cloud HSM Cluster public network access. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connection resources. </param>
        /// <param name="statusMessage"> Cloud HSM Cluster status message. </param>
        /// <param name="restoreProperties"> Cloud Hsm Cluster restore information. </param>
        /// <param name="backupProperties"> Cloud Hsm Cluster backup information. </param>
        /// <param name="sku"> SKU details. </param>
        /// <param name="identity"> Managed service identity (system assigned and/or user assigned identities). </param>
        /// <returns> A new <see cref="HardwareSecurityModules.CloudHsmClusterData"/> instance for mocking. </returns>
        public static CloudHsmClusterData CloudHsmClusterData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ProvisioningState? provisioningState = null, string autoGeneratedDomainNameLabelScope = null, CloudHsmClusterSecurityDomainProperties securityDomain = null, IEnumerable<CloudHsmProperties> hsms = null, string publicNetworkAccess = null, IEnumerable<HardwareSecurityModulesPrivateEndpointConnectionData> privateEndpointConnections = null, string statusMessage = null, RestoreProperties restoreProperties = null, BackupProperties backupProperties = null, CloudHsmClusterSku sku = null, ManagedServiceIdentity identity = null)
        {
            tags ??= new Dictionary<string, string>();
            hsms ??= new List<CloudHsmProperties>();
            privateEndpointConnections ??= new List<HardwareSecurityModulesPrivateEndpointConnectionData>();

            return new CloudHsmClusterData(id, name, resourceType, systemData, tags, location, provisioningState, autoGeneratedDomainNameLabelScope, securityDomain, hsms?.ToList(), publicNetworkAccess, privateEndpointConnections?.ToList(), statusMessage, restoreProperties, backupProperties, sku, identity, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="HardwareSecurityModules.HardwareSecurityModulesPrivateEndpointConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> Modified whenever there is a change in the state of private endpoint connection. </param>
        /// <param name="privateEndpointId"> The private endpoint resource. </param>
        /// <param name="connectionState"> A collection of information about the state of the connection between service consumer and provider. </param>
        /// <param name="provisioningState"> The provisioning state of the private endpoint connection resource. </param>
        /// <param name="groupIds"> The group ids for the private endpoint resource. </param>
        /// <returns> A new <see cref="HardwareSecurityModules.HardwareSecurityModulesPrivateEndpointConnectionData"/> instance for mocking. </returns>
        public static HardwareSecurityModulesPrivateEndpointConnectionData HardwareSecurityModulesPrivateEndpointConnectionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ETag? etag = null, ResourceIdentifier privateEndpointId = null, HardwareSecurityModulesPrivateLinkServiceConnectionState connectionState = null, HardwareSecurityModulesPrivateEndpointConnectionProvisioningState? provisioningState = null, IEnumerable<string> groupIds = null)
        {
            groupIds ??= new List<string>();

            return new HardwareSecurityModulesPrivateEndpointConnectionData(id, name, resourceType, systemData, etag, privateEndpointId != null ? ResourceManagerModelFactory.SubResource(privateEndpointId) : null, connectionState, provisioningState, groupIds?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.BackupProperties"/>. </summary>
        /// <param name="azureStorageResourceUri"> Azure storage Resource Uri. </param>
        /// <param name="lastBackupOn"> Last Date Time that Customer Enabled Backup was taken. </param>
        /// <param name="lastBackupStatus"> Status of last backup. </param>
        /// <returns> A new <see cref="Models.BackupProperties"/> instance for mocking. </returns>
        public static BackupProperties BackupProperties(Uri azureStorageResourceUri = null, DateTimeOffset? lastBackupOn = null, string lastBackupStatus = null)
        {
            return new BackupProperties(azureStorageResourceUri, lastBackupOn, lastBackupStatus, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.HardwareSecurityModulesPrivateLinkData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="groupId"> The private link resource group id. </param>
        /// <param name="requiredMembers"> The private link resource required member names. </param>
        /// <param name="requiredZoneNames"> The private link resource private link DNS zone name. </param>
        /// <returns> A new <see cref="Models.HardwareSecurityModulesPrivateLinkData"/> instance for mocking. </returns>
        public static HardwareSecurityModulesPrivateLinkData HardwareSecurityModulesPrivateLinkData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string groupId = null, IEnumerable<string> requiredMembers = null, IEnumerable<string> requiredZoneNames = null)
        {
            requiredMembers ??= new List<string>();
            requiredZoneNames ??= new List<string>();

            return new HardwareSecurityModulesPrivateLinkData(id, name, resourceType, systemData, groupId, requiredMembers?.ToList(), requiredZoneNames?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="HardwareSecurityModules.DedicatedHsmData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="networkProfile"> Specifies the network interfaces of the dedicated hsm. </param>
        /// <param name="managementNetworkProfile"> Specifies the management network interfaces of the dedicated hsm. </param>
        /// <param name="stampId"> This field will be used when RP does not support Availability zones. </param>
        /// <param name="statusMessage"> Resource Status Message. </param>
        /// <param name="provisioningState"> Provisioning state. </param>
        /// <param name="skuName"> SKU details. </param>
        /// <param name="zones"> The Dedicated Hsm zones. </param>
        /// <returns> A new <see cref="HardwareSecurityModules.DedicatedHsmData"/> instance for mocking. </returns>
        public static DedicatedHsmData DedicatedHsmData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, NetworkProfile networkProfile = null, NetworkProfile managementNetworkProfile = null, string stampId = null, string statusMessage = null, JsonWebKeyType? provisioningState = null, HardwareSecurityModulesSkuName? skuName = null, IEnumerable<string> zones = null)
        {
            tags ??= new Dictionary<string, string>();
            zones ??= new List<string>();

            return new DedicatedHsmData(id, name, resourceType, systemData, tags, location, networkProfile, managementNetworkProfile, stampId, statusMessage, provisioningState, skuName != null ? new HardwareSecurityModulesSku(skuName, serializedAdditionalRawData: null) : null, zones?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.NetworkInterface"/>. </summary>
        /// <param name="id"> The ARM resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/... </param>
        /// <param name="privateIPAddress"> Private Ip address of the interface. </param>
        /// <returns> A new <see cref="Models.NetworkInterface"/> instance for mocking. </returns>
        public static NetworkInterface NetworkInterface(ResourceIdentifier id = null, string privateIPAddress = null)
        {
            return new NetworkInterface(id, privateIPAddress, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.OutboundEnvironmentEndpoint"/>. </summary>
        /// <param name="category"> The category of endpoints accessed by the dedicated hsm service, e.g. azure-resource-management, apiserver, etc. </param>
        /// <param name="endpoints"> The endpoints that dedicated hsm service connects to. </param>
        /// <returns> A new <see cref="Models.OutboundEnvironmentEndpoint"/> instance for mocking. </returns>
        public static OutboundEnvironmentEndpoint OutboundEnvironmentEndpoint(string category = null, IEnumerable<EndpointDependency> endpoints = null)
        {
            endpoints ??= new List<EndpointDependency>();

            return new OutboundEnvironmentEndpoint(category, endpoints?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.EndpointDependency"/>. </summary>
        /// <param name="domainName"> The domain name of the dependency. </param>
        /// <param name="endpointDetails"> The Ports and Protocols used when connecting to domainName. </param>
        /// <returns> A new <see cref="Models.EndpointDependency"/> instance for mocking. </returns>
        public static EndpointDependency EndpointDependency(string domainName = null, IEnumerable<EndpointDetail> endpointDetails = null)
        {
            endpointDetails ??= new List<EndpointDetail>();

            return new EndpointDependency(domainName, endpointDetails?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.EndpointDetail"/>. </summary>
        /// <param name="ipAddress"> An IP Address that Domain Name currently resolves to. </param>
        /// <param name="port"> The port an endpoint is connected to. </param>
        /// <param name="protocol"> The protocol used for connection. </param>
        /// <param name="description"> Description of the detail. </param>
        /// <returns> A new <see cref="Models.EndpointDetail"/> instance for mocking. </returns>
        public static EndpointDetail EndpointDetail(string ipAddress = null, int? port = null, string protocol = null, string description = null)
        {
            return new EndpointDetail(ipAddress, port, protocol, description, serializedAdditionalRawData: null);
        }
    }
}
