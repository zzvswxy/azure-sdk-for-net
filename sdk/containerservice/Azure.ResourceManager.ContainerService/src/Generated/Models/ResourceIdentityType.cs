// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> For more information see [use managed identities in AKS](https://docs.microsoft.com/azure/aks/use-managed-identity). </summary>
    public enum ResourceIdentityType
    {
        /// <summary> Do not use a managed identity for the Managed Cluster, service principal will be used instead. </summary>
        None,
        /// <summary> Use an implicitly created system assigned managed identity to manage cluster resources. Master components in the control plane such as kube-controller-manager will use the system assigned managed identity to manipulate Azure resources. </summary>
        SystemAssigned,
        /// <summary> Use a user-specified identity to manage cluster resources. Master components in the control plane such as kube-controller-manager will use the specified user assigned managed identity to manipulate Azure resources. </summary>
        UserAssigned
    }
}
