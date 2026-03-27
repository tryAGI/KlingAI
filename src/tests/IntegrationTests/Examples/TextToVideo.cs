/*
order: 10
title: Text to Video
slug: text-to-video

Shows how to create a text-to-video generation task and retrieve its status.
*/

namespace KlingAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task TextToVideo()
    {
        using var client = GetAuthenticatedClient();

        //// Create a text-to-video task using the Kling v2 model with a 5-second duration.
        var createResponse = await client.CreateTextToVideoAsync(
            prompt: "A golden retriever running through a sunlit meadow, cinematic slow motion",
            modelName: CreateTextToVideoRequestModelName.KlingV2,
            mode: CreateTextToVideoRequestMode.Std,
            aspectRatio: CreateTextToVideoRequestAspectRatio.x16_9,
            duration: CreateTextToVideoRequestDuration.x5);

        createResponse.Code.Should().Be(0);
        createResponse.Data.Should().NotBeNull();
        createResponse.Data!.TaskId.Should().NotBeNullOrEmpty();
        Console.WriteLine($"Task ID: {createResponse.Data.TaskId}");
        Console.WriteLine($"Task Status: {createResponse.Data.TaskStatus}");

        //// Retrieve the task to check its status and get the result when complete.
        var taskResponse = await client.GetTextToVideoTaskAsync(
            id: createResponse.Data.TaskId!);

        taskResponse.Code.Should().Be(0);
        taskResponse.Data.Should().NotBeNull();
        taskResponse.Data!.TaskStatus.Should().NotBeNull();
        Console.WriteLine($"Status: {taskResponse.Data.TaskStatus}");

        //// When the task succeeds, the result will contain video URLs.
        if (taskResponse.Data.TaskStatus == TaskDataTaskStatus.Succeed)
        {
            taskResponse.Data.TaskResult.Should().NotBeNull();
            taskResponse.Data.TaskResult!.Videos.Should().NotBeNullOrEmpty();
            Console.WriteLine($"Video URL: {taskResponse.Data.TaskResult.Videos![0].Url}");
        }
    }
}
