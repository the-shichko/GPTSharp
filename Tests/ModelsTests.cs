using GPTSharp;

namespace Tests;

public class ModelsTests
{
    [Fact]
    public async Task GetModels()
    {
        var openAi = new OpenAIService("your_api_key");
        var result = await openAi.ModelsEndpoint.GetModels();
        Assert.True(result.IsSuccess);
    }
    
    [Theory]
    [InlineData("babbage")]
    public async Task GetModelById(string id)
    {
        var openAi = new OpenAIService("your_api_key");
        var result = await openAi.ModelsEndpoint.GetModelById(id);
        Assert.True(result.IsSuccess);
    }
}