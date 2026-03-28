
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace KlingAI
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::KlingAI.JsonConverters.CameraControlTypeJsonConverter),

            typeof(global::KlingAI.JsonConverters.CameraControlTypeNullableJsonConverter),

            typeof(global::KlingAI.JsonConverters.EffectsInputEffectSceneJsonConverter),

            typeof(global::KlingAI.JsonConverters.EffectsInputEffectSceneNullableJsonConverter),

            typeof(global::KlingAI.JsonConverters.TaskDataTaskStatusJsonConverter),

            typeof(global::KlingAI.JsonConverters.TaskDataTaskStatusNullableJsonConverter),

            typeof(global::KlingAI.JsonConverters.TaskListDataTaskStatusJsonConverter),

            typeof(global::KlingAI.JsonConverters.TaskListDataTaskStatusNullableJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateTextToVideoRequestModelNameJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateTextToVideoRequestModelNameNullableJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateTextToVideoRequestModeJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateTextToVideoRequestModeNullableJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateTextToVideoRequestAspectRatioJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateTextToVideoRequestAspectRatioNullableJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateTextToVideoRequestDurationJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateTextToVideoRequestDurationNullableJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateTextToVideoRequestSoundJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateTextToVideoRequestSoundNullableJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateImageToVideoRequestModelNameJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateImageToVideoRequestModelNameNullableJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateImageToVideoRequestModeJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateImageToVideoRequestModeNullableJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateImageToVideoRequestAspectRatioJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateImageToVideoRequestAspectRatioNullableJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateImageToVideoRequestDurationJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateImageToVideoRequestDurationNullableJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateImageToVideoRequestSoundJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateImageToVideoRequestSoundNullableJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateAvatarRequestModeJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateAvatarRequestModeNullableJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateImageGenerationRequestModelNameJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateImageGenerationRequestModelNameNullableJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateImageGenerationRequestImageReferenceJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateImageGenerationRequestImageReferenceNullableJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateImageGenerationRequestAspectRatioJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateImageGenerationRequestAspectRatioNullableJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateImageGenerationRequestResolutionJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateImageGenerationRequestResolutionNullableJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateMultiImageGenerationRequestAspectRatioJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateMultiImageGenerationRequestAspectRatioNullableJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateImageExpansionRequestAspectRatioJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateImageExpansionRequestAspectRatioNullableJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateVirtualTryOnRequestModelNameJsonConverter),

            typeof(global::KlingAI.JsonConverters.CreateVirtualTryOnRequestModelNameNullableJsonConverter),

            typeof(global::KlingAI.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.CameraControlConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.CameraControl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.CameraControlType), TypeInfoPropertyName = "CameraControlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.DynamicMask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.VoiceItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.ExpansionRatio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.LipSyncInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.EffectsInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.EffectsInputEffectScene), TypeInfoPropertyName = "EffectsInputEffectScene2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.VideoResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.ImageResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.TaskInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.TaskResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::KlingAI.VideoResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::KlingAI.ImageResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.TaskData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.TaskDataTaskStatus), TypeInfoPropertyName = "TaskDataTaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.TaskResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.TaskListData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.TaskListDataTaskStatus), TypeInfoPropertyName = "TaskListDataTaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.TaskListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::KlingAI.TaskListData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.CreateTaskData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.CreateTaskResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.ResourcePackage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.AccountCostsData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::KlingAI.ResourcePackage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.AccountCostsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.CreateTextToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.CreateTextToVideoRequestModelName), TypeInfoPropertyName = "CreateTextToVideoRequestModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.CreateTextToVideoRequestMode), TypeInfoPropertyName = "CreateTextToVideoRequestMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.CreateTextToVideoRequestAspectRatio), TypeInfoPropertyName = "CreateTextToVideoRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.CreateTextToVideoRequestDuration), TypeInfoPropertyName = "CreateTextToVideoRequestDuration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.CreateTextToVideoRequestSound), TypeInfoPropertyName = "CreateTextToVideoRequestSound2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.CreateImageToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.CreateImageToVideoRequestModelName), TypeInfoPropertyName = "CreateImageToVideoRequestModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.CreateImageToVideoRequestMode), TypeInfoPropertyName = "CreateImageToVideoRequestMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.CreateImageToVideoRequestAspectRatio), TypeInfoPropertyName = "CreateImageToVideoRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.CreateImageToVideoRequestDuration), TypeInfoPropertyName = "CreateImageToVideoRequestDuration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.CreateImageToVideoRequestSound), TypeInfoPropertyName = "CreateImageToVideoRequestSound2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::KlingAI.DynamicMask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::KlingAI.VoiceItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.CreateVideoExtensionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.CreateLipSyncRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.CreateVideoEffectsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.CreateAvatarRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.CreateAvatarRequestMode), TypeInfoPropertyName = "CreateAvatarRequestMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.CreateImageGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.CreateImageGenerationRequestModelName), TypeInfoPropertyName = "CreateImageGenerationRequestModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.CreateImageGenerationRequestImageReference), TypeInfoPropertyName = "CreateImageGenerationRequestImageReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.CreateImageGenerationRequestAspectRatio), TypeInfoPropertyName = "CreateImageGenerationRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.CreateImageGenerationRequestResolution), TypeInfoPropertyName = "CreateImageGenerationRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.CreateMultiImageGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.CreateMultiImageGenerationRequestAspectRatio), TypeInfoPropertyName = "CreateMultiImageGenerationRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.CreateImageExpansionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.CreateImageExpansionRequestAspectRatio), TypeInfoPropertyName = "CreateImageExpansionRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.CreateVirtualTryOnRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::KlingAI.CreateVirtualTryOnRequestModelName), TypeInfoPropertyName = "CreateVirtualTryOnRequestModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::KlingAI.VideoResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::KlingAI.ImageResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::KlingAI.TaskListData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::KlingAI.ResourcePackage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::KlingAI.DynamicMask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::KlingAI.VoiceItem>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}