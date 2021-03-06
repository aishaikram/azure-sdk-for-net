// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VirtualHub : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Etag != null)
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Type != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Location != null)
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Tags != null)
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (VirtualWan != null)
            {
                writer.WritePropertyName("virtualWan");
                writer.WriteObjectValue(VirtualWan);
            }
            if (VpnGateway != null)
            {
                writer.WritePropertyName("vpnGateway");
                writer.WriteObjectValue(VpnGateway);
            }
            if (P2SVpnGateway != null)
            {
                writer.WritePropertyName("p2SVpnGateway");
                writer.WriteObjectValue(P2SVpnGateway);
            }
            if (ExpressRouteGateway != null)
            {
                writer.WritePropertyName("expressRouteGateway");
                writer.WriteObjectValue(ExpressRouteGateway);
            }
            if (AzureFirewall != null)
            {
                writer.WritePropertyName("azureFirewall");
                writer.WriteObjectValue(AzureFirewall);
            }
            if (SecurityPartnerProvider != null)
            {
                writer.WritePropertyName("securityPartnerProvider");
                writer.WriteObjectValue(SecurityPartnerProvider);
            }
            if (VirtualNetworkConnections != null)
            {
                writer.WritePropertyName("virtualNetworkConnections");
                writer.WriteStartArray();
                foreach (var item in VirtualNetworkConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (AddressPrefix != null)
            {
                writer.WritePropertyName("addressPrefix");
                writer.WriteStringValue(AddressPrefix);
            }
            if (RouteTable != null)
            {
                writer.WritePropertyName("routeTable");
                writer.WriteObjectValue(RouteTable);
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (SecurityProviderName != null)
            {
                writer.WritePropertyName("securityProviderName");
                writer.WriteStringValue(SecurityProviderName);
            }
            if (VirtualHubRouteTableV2S != null)
            {
                writer.WritePropertyName("virtualHubRouteTableV2s");
                writer.WriteStartArray();
                foreach (var item in VirtualHubRouteTableV2S)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Sku != null)
            {
                writer.WritePropertyName("sku");
                writer.WriteStringValue(Sku);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VirtualHub DeserializeVirtualHub(JsonElement element)
        {
            string etag = default;
            string id = default;
            string name = default;
            string type = default;
            string location = default;
            IDictionary<string, string> tags = default;
            SubResource virtualWan = default;
            SubResource vpnGateway = default;
            SubResource p2SVpnGateway = default;
            SubResource expressRouteGateway = default;
            SubResource azureFirewall = default;
            SubResource securityPartnerProvider = default;
            IList<HubVirtualNetworkConnection> virtualNetworkConnections = default;
            string addressPrefix = default;
            VirtualHubRouteTable routeTable = default;
            ProvisioningState? provisioningState = default;
            string securityProviderName = default;
            IList<VirtualHubRouteTableV2> virtualHubRouteTableV2s = default;
            string sku = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetString());
                        }
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("virtualWan"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualWan = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("vpnGateway"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vpnGateway = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("p2SVpnGateway"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            p2SVpnGateway = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("expressRouteGateway"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expressRouteGateway = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("azureFirewall"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureFirewall = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("securityPartnerProvider"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            securityPartnerProvider = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkConnections"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<HubVirtualNetworkConnection> array = new List<HubVirtualNetworkConnection>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(HubVirtualNetworkConnection.DeserializeHubVirtualNetworkConnection(item));
                                }
                            }
                            virtualNetworkConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("addressPrefix"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            addressPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("routeTable"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            routeTable = VirtualHubRouteTable.DeserializeVirtualHubRouteTable(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("securityProviderName"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            securityProviderName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtualHubRouteTableV2s"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VirtualHubRouteTableV2> array = new List<VirtualHubRouteTableV2>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(VirtualHubRouteTableV2.DeserializeVirtualHubRouteTableV2(item));
                                }
                            }
                            virtualHubRouteTableV2s = array;
                            continue;
                        }
                        if (property0.NameEquals("sku"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sku = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VirtualHub(id, name, type, location, tags, etag, virtualWan, vpnGateway, p2SVpnGateway, expressRouteGateway, azureFirewall, securityPartnerProvider, virtualNetworkConnections, addressPrefix, routeTable, provisioningState, securityProviderName, virtualHubRouteTableV2s, sku);
        }
    }
}
