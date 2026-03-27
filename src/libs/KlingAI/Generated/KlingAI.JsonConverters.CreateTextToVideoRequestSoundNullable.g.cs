#nullable enable

namespace KlingAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTextToVideoRequestSoundNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::KlingAI.CreateTextToVideoRequestSound?>
    {
        /// <inheritdoc />
        public override global::KlingAI.CreateTextToVideoRequestSound? Read(
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
                        return global::KlingAI.CreateTextToVideoRequestSoundExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::KlingAI.CreateTextToVideoRequestSound)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::KlingAI.CreateTextToVideoRequestSound?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::KlingAI.CreateTextToVideoRequestSound? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::KlingAI.CreateTextToVideoRequestSoundExtensions.ToValueString(value.Value));
            }
        }
    }
}
