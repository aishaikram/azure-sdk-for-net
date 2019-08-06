// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for VpnSiteLinksOperations.
    /// </summary>
    public static partial class VpnSiteLinksOperationsExtensions
    {
            /// <summary>
            /// Retrieves the details of a VPN site link.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnSite.
            /// </param>
            /// <param name='vpnSiteName'>
            /// The name of the VpnSite.
            /// </param>
            /// <param name='vpnSiteLinkName'>
            /// The name of the VpnSiteLink being retrieved.
            /// </param>
            public static VpnSiteLink Get(this IVpnSiteLinksOperations operations, string resourceGroupName, string vpnSiteName, string vpnSiteLinkName)
            {
                return operations.GetAsync(resourceGroupName, vpnSiteName, vpnSiteLinkName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves the details of a VPN site link.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnSite.
            /// </param>
            /// <param name='vpnSiteName'>
            /// The name of the VpnSite.
            /// </param>
            /// <param name='vpnSiteLinkName'>
            /// The name of the VpnSiteLink being retrieved.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VpnSiteLink> GetAsync(this IVpnSiteLinksOperations operations, string resourceGroupName, string vpnSiteName, string vpnSiteLinkName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, vpnSiteName, vpnSiteLinkName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the vpnSiteLinks in a resource group for a vpn site.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnSite.
            /// </param>
            /// <param name='vpnSiteName'>
            /// The name of the VpnSite.
            /// </param>
            public static IPage<VpnSiteLink> ListByVpnSite(this IVpnSiteLinksOperations operations, string resourceGroupName, string vpnSiteName)
            {
                return operations.ListByVpnSiteAsync(resourceGroupName, vpnSiteName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the vpnSiteLinks in a resource group for a vpn site.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnSite.
            /// </param>
            /// <param name='vpnSiteName'>
            /// The name of the VpnSite.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VpnSiteLink>> ListByVpnSiteAsync(this IVpnSiteLinksOperations operations, string resourceGroupName, string vpnSiteName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByVpnSiteWithHttpMessagesAsync(resourceGroupName, vpnSiteName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the vpnSiteLinks in a resource group for a vpn site.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<VpnSiteLink> ListByVpnSiteNext(this IVpnSiteLinksOperations operations, string nextPageLink)
            {
                return operations.ListByVpnSiteNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the vpnSiteLinks in a resource group for a vpn site.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VpnSiteLink>> ListByVpnSiteNextAsync(this IVpnSiteLinksOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByVpnSiteNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}