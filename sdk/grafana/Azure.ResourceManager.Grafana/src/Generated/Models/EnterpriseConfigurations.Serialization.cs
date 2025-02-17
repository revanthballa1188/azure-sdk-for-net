// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Grafana.Models
{
    public partial class EnterpriseConfigurations : IUtf8JsonSerializable, IJsonModel<EnterpriseConfigurations>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EnterpriseConfigurations>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EnterpriseConfigurations>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EnterpriseConfigurations>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EnterpriseConfigurations)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MarketplacePlanId))
            {
                writer.WritePropertyName("marketplacePlanId"u8);
                writer.WriteStringValue(MarketplacePlanId);
            }
            if (Optional.IsDefined(MarketplaceAutoRenew))
            {
                writer.WritePropertyName("marketplaceAutoRenew"u8);
                writer.WriteStringValue(MarketplaceAutoRenew.Value.ToString());
            }
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

        EnterpriseConfigurations IJsonModel<EnterpriseConfigurations>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EnterpriseConfigurations>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EnterpriseConfigurations)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEnterpriseConfigurations(document.RootElement, options);
        }

        internal static EnterpriseConfigurations DeserializeEnterpriseConfigurations(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> marketplacePlanId = default;
            Optional<MarketplaceAutoRenew> marketplaceAutoRenew = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("marketplacePlanId"u8))
                {
                    marketplacePlanId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("marketplaceAutoRenew"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    marketplaceAutoRenew = new MarketplaceAutoRenew(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EnterpriseConfigurations(marketplacePlanId.Value, Optional.ToNullable(marketplaceAutoRenew), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EnterpriseConfigurations>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EnterpriseConfigurations>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EnterpriseConfigurations)} does not support '{options.Format}' format.");
            }
        }

        EnterpriseConfigurations IPersistableModel<EnterpriseConfigurations>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EnterpriseConfigurations>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEnterpriseConfigurations(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EnterpriseConfigurations)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EnterpriseConfigurations>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
