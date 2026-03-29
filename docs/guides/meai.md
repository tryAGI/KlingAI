# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The KlingAI SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to Kling AI's text-to-video, image-to-video, and image generation capabilities.

## Installation

```bash
dotnet add package KlingAI
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsTextToVideoTool()` | `TextToVideo` | Generates a video from a text prompt. Returns a task ID for status polling. |
| `AsImageToVideoTool()` | `ImageToVideo` | Generates a video from an image URL with optional prompt guidance. Returns a task ID. |
| `AsImageGenerationTool()` | `GenerateImage` | Generates images from a text prompt. Returns a task ID for status polling. |
| `AsGetTextToVideoTaskTool()` | `GetTextToVideoTask` | Retrieves status and result of a text-to-video task by ID. |
| `AsGetImageToVideoTaskTool()` | `GetImageToVideoTask` | Retrieves status and result of an image-to-video task by ID. |
| `AsGetImageGenerationTaskTool()` | `GetImageGenerationTask` | Retrieves status and result of an image generation task by ID. |

## Text-to-Video Tool

Use `AsTextToVideoTool()` to create an `AIFunction` that generates videos from text descriptions:

```csharp
using KlingAI;
using Microsoft.Extensions.AI;

var klingClient = new KlingAIClient(apiKey: Environment.GetEnvironmentVariable("KLINGAI_API_KEY")!);

var textToVideoTool = klingClient.AsTextToVideoTool(
    modelName: CreateTextToVideoRequestModelName.KlingV2,
    duration: CreateTextToVideoRequestDuration.x5);

// Use with any IChatClient
IChatClient chatClient = /* your chat client */;
var options = new ChatOptions
{
    Tools = [textToVideoTool],
};

var response = await chatClient.GetResponseAsync(
    "Create a video of a sunset over the ocean with gentle waves",
    options);
```

## Image-to-Video Tool

Use `AsImageToVideoTool()` to animate an image into a video:

```csharp
var imageToVideoTool = klingClient.AsImageToVideoTool(
    modelName: CreateImageToVideoRequestModelName.KlingV2);

var options = new ChatOptions
{
    Tools = [imageToVideoTool],
};
```

## Image Generation Tool

Use `AsImageGenerationTool()` to generate images from text:

```csharp
var imageGenTool = klingClient.AsImageGenerationTool(
    modelName: CreateImageGenerationRequestModelName.KlingV2,
    n: 2);

var options = new ChatOptions
{
    Tools = [imageGenTool],
};
```

## Task Status Tools

Kling AI uses an async task pattern -- creation endpoints return a task ID, and you poll for results. The `AsGet*TaskTool()` methods let the AI agent check task status:

```csharp
var options = new ChatOptions
{
    Tools =
    [
        klingClient.AsTextToVideoTool(),
        klingClient.AsGetTextToVideoTaskTool(),
    ],
};
```

## Combining All Tools

All tools can be used together to give the AI agent full generation and status-checking capabilities:

```csharp
var options = new ChatOptions
{
    Tools =
    [
        klingClient.AsTextToVideoTool(),
        klingClient.AsImageToVideoTool(),
        klingClient.AsImageGenerationTool(),
        klingClient.AsGetTextToVideoTaskTool(),
        klingClient.AsGetImageToVideoTaskTool(),
        klingClient.AsGetImageGenerationTaskTool(),
    ],
};
```

## Async Task Pattern

Kling AI generation tasks are asynchronous. The creation tools (`AsTextToVideoTool`, `AsImageToVideoTool`, `AsImageGenerationTool`) return a task ID and initial status. The status tools (`AsGetTextToVideoTaskTool`, `AsGetImageToVideoTaskTool`, `AsGetImageGenerationTaskTool`) can then be used to poll for completion. Task statuses are:

- `submitted` -- Task has been received
- `processing` -- Generation is in progress
- `succeed` -- Generation complete, results available
- `failed` -- Generation failed
