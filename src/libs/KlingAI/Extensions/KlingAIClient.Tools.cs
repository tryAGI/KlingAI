using Microsoft.Extensions.AI;

namespace KlingAI;

/// <summary>
/// Extensions for using KlingAIClient as MEAI tools with any IChatClient.
/// </summary>
public static class KlingAIToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that generates a video from a text prompt
    /// using the Kling AI text-to-video API. Returns the created task ID and status.
    /// </summary>
    /// <param name="client">The KlingAI client to use for generation.</param>
    /// <param name="modelName">Model to use (default: kling-v2).</param>
    /// <param name="mode">Generation mode (default: std).</param>
    /// <param name="aspectRatio">Aspect ratio of the output video (default: 16:9).</param>
    /// <param name="duration">Duration of the video in seconds (default: 5).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsTextToVideoTool(
        this KlingAIClient client,
        CreateTextToVideoRequestModelName modelName = CreateTextToVideoRequestModelName.KlingV2,
        CreateTextToVideoRequestMode mode = CreateTextToVideoRequestMode.Std,
        CreateTextToVideoRequestAspectRatio aspectRatio = CreateTextToVideoRequestAspectRatio.x16_9,
        CreateTextToVideoRequestDuration duration = CreateTextToVideoRequestDuration.x5)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string prompt, string? negativePrompt, CancellationToken cancellationToken) =>
            {
                var response = await client.CreateTextToVideoAsync(
                    prompt: prompt,
                    modelName: modelName,
                    negativePrompt: negativePrompt,
                    mode: mode,
                    aspectRatio: aspectRatio,
                    duration: duration,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatCreateTaskResponse(response, "text-to-video");
            },
            name: "TextToVideo",
            description: "Generates a video from a text description using Kling AI. Provide a detailed prompt describing the desired video content, style, and motion. Returns a task ID that can be used to check generation status.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that generates a video from an image
    /// using the Kling AI image-to-video API. Returns the created task ID and status.
    /// </summary>
    /// <param name="client">The KlingAI client to use for generation.</param>
    /// <param name="modelName">Model to use (default: kling-v2).</param>
    /// <param name="mode">Generation mode (default: std).</param>
    /// <param name="duration">Duration of the video in seconds (default: 5).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsImageToVideoTool(
        this KlingAIClient client,
        CreateImageToVideoRequestModelName modelName = CreateImageToVideoRequestModelName.KlingV2,
        CreateImageToVideoRequestMode mode = CreateImageToVideoRequestMode.Std,
        CreateImageToVideoRequestDuration duration = CreateImageToVideoRequestDuration.x5)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string imageUrl, string? prompt, CancellationToken cancellationToken) =>
            {
                var response = await client.CreateImageToVideoAsync(
                    image: imageUrl,
                    prompt: prompt,
                    modelName: modelName,
                    mode: mode,
                    duration: duration,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatCreateTaskResponse(response, "image-to-video");
            },
            name: "ImageToVideo",
            description: "Generates a video from a given image URL using Kling AI. Optionally accepts a text prompt to guide the motion and content of the generated video. Returns a task ID that can be used to check generation status.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that generates images from a text prompt
    /// using the Kling AI image generation API. Returns the created task ID and status.
    /// </summary>
    /// <param name="client">The KlingAI client to use for generation.</param>
    /// <param name="modelName">Model to use (default: kling-v2).</param>
    /// <param name="aspectRatio">Aspect ratio of the output image (default: 16:9).</param>
    /// <param name="n">Number of images to generate (default: 1).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsImageGenerationTool(
        this KlingAIClient client,
        CreateImageGenerationRequestModelName modelName = CreateImageGenerationRequestModelName.KlingV2,
        CreateImageGenerationRequestAspectRatio aspectRatio = CreateImageGenerationRequestAspectRatio.x16_9,
        int n = 1)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string prompt, string? negativePrompt, CancellationToken cancellationToken) =>
            {
                var response = await client.CreateImageGenerationAsync(
                    prompt: prompt,
                    modelName: modelName,
                    negativePrompt: negativePrompt,
                    aspectRatio: aspectRatio,
                    n: n,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatCreateTaskResponse(response, "image-generation");
            },
            name: "GenerateImage",
            description: "Generates images from a text description using Kling AI. Provide a detailed prompt describing the desired image content and style. Returns a task ID that can be used to check generation status and retrieve the generated images.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that retrieves the status and result
    /// of a text-to-video task by its ID.
    /// </summary>
    /// <param name="client">The KlingAI client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetTextToVideoTaskTool(this KlingAIClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string taskId, CancellationToken cancellationToken) =>
            {
                var response = await client.GetTextToVideoTaskAsync(
                    id: taskId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatTaskResponse(response);
            },
            name: "GetTextToVideoTask",
            description: "Retrieves the status and result of a text-to-video generation task by its task ID. Returns the task status (submitted, processing, succeed, failed) and video URLs when complete.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that retrieves the status and result
    /// of an image-to-video task by its ID.
    /// </summary>
    /// <param name="client">The KlingAI client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetImageToVideoTaskTool(this KlingAIClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string taskId, CancellationToken cancellationToken) =>
            {
                var response = await client.GetImageToVideoTaskAsync(
                    id: taskId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatTaskResponse(response);
            },
            name: "GetImageToVideoTask",
            description: "Retrieves the status and result of an image-to-video generation task by its task ID. Returns the task status (submitted, processing, succeed, failed) and video URLs when complete.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that retrieves the status and result
    /// of an image generation task by its ID.
    /// </summary>
    /// <param name="client">The KlingAI client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetImageGenerationTaskTool(this KlingAIClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string taskId, CancellationToken cancellationToken) =>
            {
                var response = await client.GetImageGenerationTaskAsync(
                    id: taskId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatTaskResponse(response);
            },
            name: "GetImageGenerationTask",
            description: "Retrieves the status and result of an image generation task by its task ID. Returns the task status (submitted, processing, succeed, failed) and image URLs when complete.");
    }

    private static string FormatCreateTaskResponse(CreateTaskResponse response, string taskType)
    {
        var parts = new List<string>();

        if (response.Code == 0)
        {
            parts.Add($"Task created successfully ({taskType}).");
            if (response.Data is { } data)
            {
                if (!string.IsNullOrWhiteSpace(data.TaskId))
                {
                    parts.Add($"Task ID: {data.TaskId}");
                }
                if (!string.IsNullOrWhiteSpace(data.TaskStatus))
                {
                    parts.Add($"Status: {data.TaskStatus}");
                }
            }
        }
        else
        {
            parts.Add($"Task creation failed ({taskType}).");
            if (!string.IsNullOrWhiteSpace(response.Message))
            {
                parts.Add($"Error: {response.Message}");
            }
        }

        return string.Join("\n", parts);
    }

    private static string FormatTaskResponse(TaskResponse response)
    {
        var parts = new List<string>();

        if (response.Code == 0 && response.Data is { } data)
        {
            if (!string.IsNullOrWhiteSpace(data.TaskId))
            {
                parts.Add($"Task ID: {data.TaskId}");
            }
            if (data.TaskStatus is { } status)
            {
                parts.Add($"Status: {status.ToValueString()}");
            }
            if (!string.IsNullOrWhiteSpace(data.TaskStatusMsg))
            {
                parts.Add($"Message: {data.TaskStatusMsg}");
            }

            if (data.TaskStatus == TaskDataTaskStatus.Succeed && data.TaskResult is { } result)
            {
                if (result.Videos is { Count: > 0 })
                {
                    parts.Add("Videos:");
                    foreach (var video in result.Videos)
                    {
                        var entry = $"- {video.Url}";
                        if (!string.IsNullOrWhiteSpace(video.Duration))
                        {
                            entry += $" ({video.Duration}s)";
                        }
                        parts.Add(entry);
                    }
                }

                if (result.Images is { Count: > 0 })
                {
                    parts.Add("Images:");
                    foreach (var image in result.Images)
                    {
                        parts.Add($"- [{image.Index}] {image.Url}");
                    }
                }
            }
        }
        else
        {
            parts.Add("Task query failed.");
            if (!string.IsNullOrWhiteSpace(response.Message))
            {
                parts.Add($"Error: {response.Message}");
            }
        }

        return string.Join("\n", parts);
    }
}
