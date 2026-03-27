/*
order: 40
title: MEAI Tools
slug: meai-tools

Shows how to use KlingAI AIFunction tools with any IChatClient.
*/

namespace KlingAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void AsTextToVideoTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a text-to-video tool from the KlingAI client for use with any IChatClient.
        var tool = client.AsTextToVideoTool(
            modelName: CreateTextToVideoRequestModelName.KlingV2,
            duration: CreateTextToVideoRequestDuration.x5);
        tool.Name.Should().Be("TextToVideo");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsImageToVideoTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create an image-to-video tool for animating images into videos.
        var tool = client.AsImageToVideoTool(
            modelName: CreateImageToVideoRequestModelName.KlingV2);
        tool.Name.Should().Be("ImageToVideo");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsImageGenerationTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create an image generation tool for producing images from text prompts.
        var tool = client.AsImageGenerationTool(
            modelName: CreateImageGenerationRequestModelName.KlingV2,
            n: 1);
        tool.Name.Should().Be("GenerateImage");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsGetTextToVideoTaskTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a task status tool for checking text-to-video generation progress.
        var tool = client.AsGetTextToVideoTaskTool();
        tool.Name.Should().Be("GetTextToVideoTask");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsGetImageToVideoTaskTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a task status tool for checking image-to-video generation progress.
        var tool = client.AsGetImageToVideoTaskTool();
        tool.Name.Should().Be("GetImageToVideoTask");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsGetImageGenerationTaskTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a task status tool for checking image generation progress.
        var tool = client.AsGetImageGenerationTaskTool();
        tool.Name.Should().Be("GetImageGenerationTask");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void CombineAllTools()
    {
        using var client = GetAuthenticatedClient();

        //// Combine all tools for full generation and status-checking capabilities.
        var tools = new[]
        {
            client.AsTextToVideoTool(),
            client.AsImageToVideoTool(),
            client.AsImageGenerationTool(),
            client.AsGetTextToVideoTaskTool(),
            client.AsGetImageToVideoTaskTool(),
            client.AsGetImageGenerationTaskTool(),
        };

        tools.Should().HaveCount(6);
        tools.Select(t => t.Name).Should().OnlyHaveUniqueItems();
    }
}
