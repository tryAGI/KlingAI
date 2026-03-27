# CLAUDE.md -- KlingAI SDK

## Overview

Auto-generated C# SDK for [Kling AI](https://klingai.com/) -- AI-powered video and image generation with text-to-video, image-to-video, video extension, lip sync, effects, avatar creation, and image generation.
**No public OpenAPI spec exists** -- `openapi.yaml` was manually created from Kling AI API documentation.

## Build & Test

```bash
dotnet build KlingAI.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth (JWT token):

```csharp
var client = new KlingAIClient(apiKey); // KLINGAI_API_KEY env var
```

Base URL: `https://api.klingai.com`

## Key Files

- `src/libs/KlingAI/openapi.yaml` -- **Manually maintained** OpenAPI spec (no public spec from Kling AI)
- `src/libs/KlingAI/generate.sh` -- Runs autosdk on local spec (no download step)
- `src/libs/KlingAI/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/KlingAI/Extensions/KlingAIClient.Tools.cs` -- MEAI `AIFunction` tools (TextToVideo, ImageToVideo, ImageGeneration, task status retrieval)
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Spec Notes

- **No public OpenAPI spec exists** -- `openapi.yaml` was manually created from Kling AI API docs
- All generation endpoints follow an async task pattern: POST creates a task, GET polls for status (submitted, processing, succeed, failed)
- SSE streaming endpoints were omitted from the spec (users poll instead)
- No sub-client pattern -- all operations are on the flat `KlingAIClient`
- Uses `--exclude-deprecated-operations` flag

## Async Task Pattern

Two-step generation workflow:
1. **Create:** `client.CreateTextToVideoAsync(prompt, ...)` -- returns `CreateTaskResponse` with `TaskId` and `TaskStatus`
2. **Poll:** `client.GetTextToVideoTaskAsync(taskId)` -- check `TaskStatus` (`submitted` -> `processing` -> `succeed`), then access video/image URLs from `TaskResult`

Same pattern applies to image-to-video, image generation, and all other generation endpoints.

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsTextToVideoTool(modelName, mode, aspectRatio, duration)` -- Generate video from text prompt
- `AsImageToVideoTool(modelName, mode, duration)` -- Generate video from image URL
- `AsImageGenerationTool(modelName, aspectRatio, n)` -- Generate images from text prompt
- `AsGetTextToVideoTaskTool()` -- Get text-to-video task status and video URLs
- `AsGetImageToVideoTaskTool()` -- Get image-to-video task status and video URLs
- `AsGetImageGenerationTaskTool()` -- Get image generation task status and image URLs

No MEAI interface (`IChatClient`, `IEmbeddingGenerator`, `ISpeechToTextClient`) is implemented -- Kling AI is a video/image generation platform with no matching MEAI interface.
