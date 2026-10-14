#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Turbopuffer.JsonConverters
{
    /// <inheritdoc />
    public class CopyFromNamespaceOperationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Turbopuffer.CopyFromNamespaceOperation>
    {
        /// <inheritdoc />
        public override global::Turbopuffer.CopyFromNamespaceOperation Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Turbopuffer.CopyFromNamespaceOperationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Turbopuffer.CopyFromNamespaceOperationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Turbopuffer.CopyFromNamespaceOperationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Turbopuffer.CopyFromNamespaceOperationRunning? running = default;
            if (discriminator?.Status == global::Turbopuffer.CopyFromNamespaceOperationDiscriminatorStatus.Running)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Turbopuffer.CopyFromNamespaceOperationRunning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Turbopuffer.CopyFromNamespaceOperationRunning> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Turbopuffer.CopyFromNamespaceOperationRunning)}");
                running = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Turbopuffer.CopyFromNamespaceOperationFinished? finished = default;
            if (discriminator?.Status == global::Turbopuffer.CopyFromNamespaceOperationDiscriminatorStatus.Finished)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Turbopuffer.CopyFromNamespaceOperationFinished), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Turbopuffer.CopyFromNamespaceOperationFinished> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Turbopuffer.CopyFromNamespaceOperationFinished)}");
                finished = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Turbopuffer.CopyFromNamespaceOperation(
                discriminator?.Status,
                running,

                finished
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Turbopuffer.CopyFromNamespaceOperation value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRunning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Turbopuffer.CopyFromNamespaceOperationRunning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Turbopuffer.CopyFromNamespaceOperationRunning?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Turbopuffer.CopyFromNamespaceOperationRunning).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRunning(), typeInfo);
            }
            else if (value.IsFinished)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Turbopuffer.CopyFromNamespaceOperationFinished), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Turbopuffer.CopyFromNamespaceOperationFinished?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Turbopuffer.CopyFromNamespaceOperationFinished).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFinished(), typeInfo);
            }
        }
    }
}