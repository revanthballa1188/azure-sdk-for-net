// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class HciClusterIdentityResult : IUtf8JsonSerializable, IJsonModel<HciClusterIdentityResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HciClusterIdentityResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HciClusterIdentityResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciClusterIdentityResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HciClusterIdentityResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AadClientId))
            {
                writer.WritePropertyName("aadClientId"u8);
                writer.WriteStringValue(AadClientId.Value);
            }
            if (Optional.IsDefined(AadTenantId))
            {
                writer.WritePropertyName("aadTenantId"u8);
                writer.WriteStringValue(AadTenantId.Value);
            }
            if (Optional.IsDefined(AadServicePrincipalObjectId))
            {
                writer.WritePropertyName("aadServicePrincipalObjectId"u8);
                writer.WriteStringValue(AadServicePrincipalObjectId.Value);
            }
            if (Optional.IsDefined(AadApplicationObjectId))
            {
                writer.WritePropertyName("aadApplicationObjectId"u8);
                writer.WriteStringValue(AadApplicationObjectId.Value);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        HciClusterIdentityResult IJsonModel<HciClusterIdentityResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciClusterIdentityResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HciClusterIdentityResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHciClusterIdentityResult(document.RootElement, options);
        }

        internal static HciClusterIdentityResult DeserializeHciClusterIdentityResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> aadClientId = default;
            Optional<Guid> aadTenantId = default;
            Optional<Guid> aadServicePrincipalObjectId = default;
            Optional<Guid> aadApplicationObjectId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("aadClientId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            aadClientId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("aadTenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            aadTenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("aadServicePrincipalObjectId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            aadServicePrincipalObjectId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("aadApplicationObjectId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            aadApplicationObjectId = property0.Value.GetGuid();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HciClusterIdentityResult(Optional.ToNullable(aadClientId), Optional.ToNullable(aadTenantId), Optional.ToNullable(aadServicePrincipalObjectId), Optional.ToNullable(aadApplicationObjectId), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HciClusterIdentityResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciClusterIdentityResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HciClusterIdentityResult)} does not support '{options.Format}' format.");
            }
        }

        HciClusterIdentityResult IPersistableModel<HciClusterIdentityResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciClusterIdentityResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHciClusterIdentityResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HciClusterIdentityResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HciClusterIdentityResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
