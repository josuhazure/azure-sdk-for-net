// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class PacketCaptureFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol");
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (Optional.IsDefined(LocalIPAddress))
            {
                writer.WritePropertyName("localIPAddress");
                writer.WriteStringValue(LocalIPAddress);
            }
            if (Optional.IsDefined(RemoteIPAddress))
            {
                writer.WritePropertyName("remoteIPAddress");
                writer.WriteStringValue(RemoteIPAddress);
            }
            if (Optional.IsDefined(LocalPort))
            {
                writer.WritePropertyName("localPort");
                writer.WriteStringValue(LocalPort);
            }
            if (Optional.IsDefined(RemotePort))
            {
                writer.WritePropertyName("remotePort");
                writer.WriteStringValue(RemotePort);
            }
            writer.WriteEndObject();
        }

        internal static PacketCaptureFilter DeserializePacketCaptureFilter(JsonElement element)
        {
            Optional<PcProtocol> protocol = default;
            Optional<string> localIPAddress = default;
            Optional<string> remoteIPAddress = default;
            Optional<string> localPort = default;
            Optional<string> remotePort = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protocol"))
                {
                    protocol = new PcProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("localIPAddress"))
                {
                    localIPAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("remoteIPAddress"))
                {
                    remoteIPAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("localPort"))
                {
                    localPort = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("remotePort"))
                {
                    remotePort = property.Value.GetString();
                    continue;
                }
            }
            return new PacketCaptureFilter(Optional.ToNullable(protocol), localIPAddress.Value, remoteIPAddress.Value, localPort.Value, remotePort.Value);
        }
    }
}
