/*
order: 20
title: Image to Video
slug: image-to-video

Shows how to create an image-to-video task from an image URL with prompt guidance.
*/

namespace KlingAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ImageToVideo()
    {
        using var client = GetAuthenticatedClient();

        //// Create an image-to-video task by providing an image URL and a motion prompt.
        var createResponse = await client.CreateImageToVideoAsync(
            image: "https://example.com/landscape.jpg",
            prompt: "Camera slowly pans across the landscape with gentle wind blowing through the trees",
            modelName: CreateImageToVideoRequestModelName.KlingV2,
            mode: CreateImageToVideoRequestMode.Std,
            duration: CreateImageToVideoRequestDuration.x5);

        createResponse.Code.Should().Be(0);
        createResponse.Data.Should().NotBeNull();
        createResponse.Data!.TaskId.Should().NotBeNullOrEmpty();
        Console.WriteLine($"Task ID: {createResponse.Data.TaskId}");

        //// Query the task status using the returned task ID.
        var taskResponse = await client.GetImageToVideoTaskAsync(
            id: createResponse.Data.TaskId!);

        taskResponse.Code.Should().Be(0);
        taskResponse.Data.Should().NotBeNull();
        taskResponse.Data!.TaskStatus.Should().NotBeNull();
        Console.WriteLine($"Status: {taskResponse.Data.TaskStatus}");

        //// When complete, the result contains generated video URLs.
        if (taskResponse.Data.TaskStatus == TaskDataTaskStatus.Succeed)
        {
            taskResponse.Data.TaskResult.Should().NotBeNull();
            taskResponse.Data.TaskResult!.Videos.Should().NotBeNullOrEmpty();
            Console.WriteLine($"Video URL: {taskResponse.Data.TaskResult.Videos![0].Url}");
            Console.WriteLine($"Duration: {taskResponse.Data.TaskResult.Videos[0].Duration}s");
        }
    }
}
