# Async Task Pattern

All generation endpoints in the Kling AI API use an asynchronous task pattern:
**POST** (create task) → **GET** (poll for status) → read results.

## Workflow

```
1. Submit generation request → receive task_id
2. Poll task status until "succeed" or "failed"
3. Read results (video/image URLs) from the completed task
```

## Example: Text-to-Video with Polling

```csharp
using KlingAI;

using var client = new KlingAIClient(apiKey);

// Step 1: Create task
var createResponse = await client.CreateTextToVideoAsync(
    prompt: "A cat playing piano in a cozy living room",
    modelName: CreateTextToVideoRequestModelName.KlingV21,
    mode: CreateTextToVideoRequestMode.Std,
    duration: CreateTextToVideoRequestDuration.x5);

var taskId = createResponse.Data!.TaskId!;

// Step 2: Poll for completion
TaskResponse taskResponse;
do
{
    await Task.Delay(TimeSpan.FromSeconds(10));
    taskResponse = await client.GetTextToVideoTaskAsync(id: taskId);
}
while (taskResponse.Data?.TaskStatus is TaskDataTaskStatus.Submitted
    or TaskDataTaskStatus.Processing);

// Step 3: Read results
if (taskResponse.Data?.TaskStatus == TaskDataTaskStatus.Succeed)
{
    foreach (var video in taskResponse.Data.TaskResult?.Videos ?? [])
    {
        Console.WriteLine($"Video: {video.Url} ({video.Duration}s)");
    }
}
```

## Task Statuses

| Status | Description |
|--------|-------------|
| `Submitted` | Task accepted, queued for processing |
| `Processing` | Generation in progress |
| `Succeed` | Complete — results available in `TaskResult` |
| `Failed` | Generation failed — check `TaskStatusMsg` |

## Callback URL

Instead of polling, you can provide a `CallbackUrl` in your request. Kling AI
will send a POST request to your URL when the task completes:

```csharp
var response = await client.CreateTextToVideoAsync(
    request: new CreateTextToVideoRequest
    {
        Prompt = "A sunset over the ocean",
        CallbackUrl = "https://your-server.com/kling-webhook",
    });
```

## Available Generation Endpoints

| Endpoint | Create | Get Status | List |
|----------|--------|------------|------|
| Text-to-Video | `CreateTextToVideoAsync` | `GetTextToVideoTaskAsync` | `ListTextToVideoTasksAsync` |
| Image-to-Video | `CreateImageToVideoAsync` | `GetImageToVideoTaskAsync` | `ListImageToVideoTasksAsync` |
| Image Generation | `CreateImageGenerationAsync` | `GetImageGenerationTaskAsync` | `ListImageGenerationTasksAsync` |
| Video Extension | `CreateVideoExtensionAsync` | `GetVideoExtensionTaskAsync` | `ListVideoExtensionTasksAsync` |
| Lip Sync | `CreateLipSyncAsync` | `GetLipSyncTaskAsync` | `ListLipSyncTasksAsync` |
| Video Effects | `CreateVideoEffectsAsync` | `GetVideoEffectsTaskAsync` | `ListVideoEffectsTasksAsync` |
| Avatar | `CreateAvatarAsync` | `GetAvatarTaskAsync` | `ListAvatarTasksAsync` |
| Virtual Try-On | `CreateVirtualTryOnAsync` | `GetVirtualTryOnTaskAsync` | `ListVirtualTryOnTasksAsync` |
