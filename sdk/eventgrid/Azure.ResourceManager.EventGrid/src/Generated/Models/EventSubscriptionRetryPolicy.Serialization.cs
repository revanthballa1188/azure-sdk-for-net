// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class EventSubscriptionRetryPolicy : IUtf8JsonSerializable, IJsonModel<EventSubscriptionRetryPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EventSubscriptionRetryPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EventSubscriptionRetryPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventSubscriptionRetryPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventSubscriptionRetryPolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MaxDeliveryAttempts))
            {
                writer.WritePropertyName("maxDeliveryAttempts"u8);
                writer.WriteNumberValue(MaxDeliveryAttempts.Value);
            }
            if (Optional.IsDefined(EventTimeToLiveInMinutes))
            {
                writer.WritePropertyName("eventTimeToLiveInMinutes"u8);
                writer.WriteNumberValue(EventTimeToLiveInMinutes.Value);
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

        EventSubscriptionRetryPolicy IJsonModel<EventSubscriptionRetryPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventSubscriptionRetryPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventSubscriptionRetryPolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEventSubscriptionRetryPolicy(document.RootElement, options);
        }

        internal static EventSubscriptionRetryPolicy DeserializeEventSubscriptionRetryPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> maxDeliveryAttempts = default;
            Optional<int> eventTimeToLiveInMinutes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxDeliveryAttempts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxDeliveryAttempts = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("eventTimeToLiveInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventTimeToLiveInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EventSubscriptionRetryPolicy(Optional.ToNullable(maxDeliveryAttempts), Optional.ToNullable(eventTimeToLiveInMinutes), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EventSubscriptionRetryPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventSubscriptionRetryPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EventSubscriptionRetryPolicy)} does not support '{options.Format}' format.");
            }
        }

        EventSubscriptionRetryPolicy IPersistableModel<EventSubscriptionRetryPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventSubscriptionRetryPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEventSubscriptionRetryPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EventSubscriptionRetryPolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EventSubscriptionRetryPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
