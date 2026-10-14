#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Turbopuffer.JsonConverters
{
    /// <inheritdoc />
    public class CopyFromNamespaceOperationResultJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Turbopuffer.CopyFromNamespaceOperationResult>
    {
        /// <inheritdoc />
        public override global::Turbopuffer.CopyFromNamespaceOperationResult Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("success")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("error")) __score1++;
            if (__jsonProps.Contains("error.detail")) __score1++;
            if (__jsonProps.Contains("error.status_code")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Turbopuffer.CopyFromNamespaceOperationResultSuccess? success = default;
            global::Turbopuffer.CopyFromNamespaceOperationResultError? error = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Turbopuffer.CopyFromNamespaceOperationResultSuccess), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Turbopuffer.CopyFromNamespaceOperationResultSuccess> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Turbopuffer.CopyFromNamespaceOperationResultSuccess).Name}");
                        success = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Turbopuffer.CopyFromNamespaceOperationResultError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Turbopuffer.CopyFromNamespaceOperationResultError> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Turbopuffer.CopyFromNamespaceOperationResultError).Name}");
                        error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (success == null && error == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Turbopuffer.CopyFromNamespaceOperationResultSuccess), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Turbopuffer.CopyFromNamespaceOperationResultSuccess> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Turbopuffer.CopyFromNamespaceOperationResultSuccess).Name}");
                    success = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (success == null && error == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Turbopuffer.CopyFromNamespaceOperationResultError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Turbopuffer.CopyFromNamespaceOperationResultError> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Turbopuffer.CopyFromNamespaceOperationResultError).Name}");
                    error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Turbopuffer.CopyFromNamespaceOperationResult(
                success,

                error
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Turbopuffer.CopyFromNamespaceOperationResult value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Turbopuffer.CopyFromNamespaceOperationResultSuccess), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Turbopuffer.CopyFromNamespaceOperationResultSuccess?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Turbopuffer.CopyFromNamespaceOperationResultSuccess).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSuccess(), typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Turbopuffer.CopyFromNamespaceOperationResultError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Turbopuffer.CopyFromNamespaceOperationResultError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Turbopuffer.CopyFromNamespaceOperationResultError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickError(), typeInfo);
            }
        }
    }
}