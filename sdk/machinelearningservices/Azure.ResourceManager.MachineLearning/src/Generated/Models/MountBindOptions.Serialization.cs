// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MountBindOptions : IUtf8JsonSerializable, IJsonModel<MountBindOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MountBindOptions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MountBindOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MountBindOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MountBindOptions)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Propagation))
            {
                if (Propagation != null)
                {
                    writer.WritePropertyName("propagation"u8);
                    writer.WriteStringValue(Propagation);
                }
                else
                {
                    writer.WriteNull("propagation");
                }
            }
            if (Optional.IsDefined(DoesCreateHostPath))
            {
                if (DoesCreateHostPath != null)
                {
                    writer.WritePropertyName("createHostPath"u8);
                    writer.WriteBooleanValue(DoesCreateHostPath.Value);
                }
                else
                {
                    writer.WriteNull("createHostPath");
                }
            }
            if (Optional.IsDefined(Selinux))
            {
                if (Selinux != null)
                {
                    writer.WritePropertyName("selinux"u8);
                    writer.WriteStringValue(Selinux);
                }
                else
                {
                    writer.WriteNull("selinux");
                }
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

        MountBindOptions IJsonModel<MountBindOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MountBindOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MountBindOptions)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMountBindOptions(document.RootElement, options);
        }

        internal static MountBindOptions DeserializeMountBindOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> propagation = default;
            Optional<bool?> createHostPath = default;
            Optional<string> selinux = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("propagation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        propagation = null;
                        continue;
                    }
                    propagation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createHostPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        createHostPath = null;
                        continue;
                    }
                    createHostPath = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("selinux"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        selinux = null;
                        continue;
                    }
                    selinux = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MountBindOptions(propagation.Value, Optional.ToNullable(createHostPath), selinux.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MountBindOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MountBindOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MountBindOptions)} does not support '{options.Format}' format.");
            }
        }

        MountBindOptions IPersistableModel<MountBindOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MountBindOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMountBindOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MountBindOptions)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MountBindOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
