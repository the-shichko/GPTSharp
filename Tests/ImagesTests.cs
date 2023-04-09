using GPTSharp;

namespace Tests;

public class ImagesTests
{
    [Fact]
    public async Task PostChatCompletions()
    {
        var openAi = new OpenAIService("your_api_key");
        var result = await openAi.ImagesEndpoint.Generations("Аниме тян", 2);
        Assert.True(result.IsSuccess);
    }
}