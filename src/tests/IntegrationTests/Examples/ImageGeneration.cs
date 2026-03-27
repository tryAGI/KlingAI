/*
order: 30
title: Image Generation
slug: image-generation

Shows how to create an image generation task from a text prompt.
*/

namespace KlingAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ImageGeneration()
    {
        using var client = GetAuthenticatedClient();

        //// Create an image generation task with a text prompt.
        var createResponse = await client.CreateImageGenerationAsync(
            prompt: "A futuristic cityscape at sunset with flying vehicles, digital art",
            modelName: CreateImageGenerationRequestModelName.KlingV2,
            aspectRatio: CreateImageGenerationRequestAspectRatio.x16_9,
            n: 1);

        createResponse.Code.Should().Be(0);
        createResponse.Data.Should().NotBeNull();
        createResponse.Data!.TaskId.Should().NotBeNullOrEmpty();
        Console.WriteLine($"Task ID: {createResponse.Data.TaskId}");
        Console.WriteLine($"Task Status: {createResponse.Data.TaskStatus}");

        //// Retrieve the task to check the generation status and result.
        var taskResponse = await client.GetImageGenerationTaskAsync(
            id: createResponse.Data.TaskId!);

        taskResponse.Code.Should().Be(0);
        taskResponse.Data.Should().NotBeNull();
        taskResponse.Data!.TaskStatus.Should().NotBeNull();
        Console.WriteLine($"Status: {taskResponse.Data.TaskStatus}");

        //// When the task succeeds, the result will contain image URLs.
        if (taskResponse.Data.TaskStatus == TaskDataTaskStatus.Succeed)
        {
            taskResponse.Data.TaskResult.Should().NotBeNull();
            taskResponse.Data.TaskResult!.Images.Should().NotBeNullOrEmpty();

            foreach (var image in taskResponse.Data.TaskResult.Images!)
            {
                Console.WriteLine($"Image {image.Index}: {image.Url}");
            }
        }
    }
}
