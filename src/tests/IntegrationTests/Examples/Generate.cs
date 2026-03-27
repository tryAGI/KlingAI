/*
order: 1
title: Getting Started
slug: getting-started

Create a KlingAI client and query your account balance.
*/

namespace KlingAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_GetAccount()
    {
        using var client = GetAuthenticatedClient();

        //// Query your account resource packages and credit consumption
        //// Time range is specified as Unix milliseconds
        var now = DateTimeOffset.UtcNow;
        var response = await client.GetAccountCostsAsync(
            startTime: now.AddDays(-30).ToUnixTimeMilliseconds(),
            endTime: now.ToUnixTimeMilliseconds());

        response.Code.Should().Be(0);

        Console.WriteLine($"Request ID: {response.RequestId}");
    }

    [TestMethod]
    public async Task Example_ListTextToVideoTasks()
    {
        using var client = GetAuthenticatedClient();

        //// List recent text-to-video tasks with pagination
        var response = await client.ListTextToVideoTasksAsync(
            pageNum: 1,
            pageSize: 5);

        response.Code.Should().Be(0);

        foreach (var task in response.Data ?? [])
        {
            Console.WriteLine($"Task {task.TaskId}: {task.TaskStatus}");
        }
    }
}
