#nullable enable

namespace KlingAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateMultiImageGenerationRequestAspectRatioNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::KlingAI.CreateMultiImageGenerationRequestAspectRatio?>
    {
        /// <inheritdoc />
        public override global::KlingAI.CreateMultiImageGenerationRequestAspectRatio? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::KlingAI.CreateMultiImageGenerationRequestAspectRatioExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::KlingAI.CreateMultiImageGenerationRequestAspectRatio)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::KlingAI.CreateMultiImageGenerationRequestAspectRatio?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::KlingAI.CreateMultiImageGenerationRequestAspectRatio? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::KlingAI.CreateMultiImageGenerationRequestAspectRatioExtensions.ToValueString(value.Value));
            }
        }
    }
}
