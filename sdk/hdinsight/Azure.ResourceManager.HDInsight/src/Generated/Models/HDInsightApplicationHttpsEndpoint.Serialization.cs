// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightApplicationHttpsEndpoint : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AccessModes))
            {
                writer.WritePropertyName("accessModes"u8);
                writer.WriteStartArray();
                foreach (var item in AccessModes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DestinationPort))
            {
                writer.WritePropertyName("destinationPort"u8);
                writer.WriteNumberValue(DestinationPort.Value);
            }
            if (Optional.IsDefined(PrivateIPAddress))
            {
                writer.WritePropertyName("privateIPAddress"u8);
                writer.WriteStringValue(PrivateIPAddress.ToString());
            }
            if (Optional.IsDefined(SubDomainSuffix))
            {
                writer.WritePropertyName("subDomainSuffix"u8);
                writer.WriteStringValue(SubDomainSuffix);
            }
            if (Optional.IsDefined(DisableGatewayAuth))
            {
                writer.WritePropertyName("disableGatewayAuth"u8);
                writer.WriteBooleanValue(DisableGatewayAuth.Value);
            }
            writer.WriteEndObject();
        }

        internal static HDInsightApplicationHttpsEndpoint DeserializeHDInsightApplicationHttpsEndpoint(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> accessModes = default;
            Optional<string> location = default;
            Optional<int> destinationPort = default;
            Optional<int> publicPort = default;
            Optional<IPAddress> privateIPAddress = default;
            Optional<string> subDomainSuffix = default;
            Optional<bool> disableGatewayAuth = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accessModes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    accessModes = array;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    destinationPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("publicPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    publicPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("privateIPAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    privateIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subDomainSuffix"u8))
                {
                    subDomainSuffix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("disableGatewayAuth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    disableGatewayAuth = property.Value.GetBoolean();
                    continue;
                }
            }
            return new HDInsightApplicationHttpsEndpoint(Optional.ToList(accessModes), location.Value, Optional.ToNullable(destinationPort), Optional.ToNullable(publicPort), privateIPAddress.Value, subDomainSuffix.Value, Optional.ToNullable(disableGatewayAuth));
        }
    }
}
