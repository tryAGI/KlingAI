#nullable enable

namespace KlingAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class TaskDataTaskStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::KlingAI.TaskDataTaskStatus>
    {
        /// <inheritdoc />
        public override global::KlingAI.TaskDataTaskStatus Read(
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
                        return global::KlingAI.TaskDataTaskStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::KlingAI.TaskDataTaskStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::KlingAI.TaskDataTaskStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::KlingAI.TaskDataTaskStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::KlingAI.TaskDataTaskStatusExtensions.ToValueString(value));
        }
    }
}
