using GPTSharp;
using GPTSharp.Models.Chat.Requests;

namespace Tests;

public class ChatTests
{
    [Fact]
    public async Task PostChatCompletions()
    {
        var openAi = new OpenAIService("your_api_key");

        var sendObject = new RequestChatCompletions
        {
            Model = "gpt-3.5-turbo",
            Temperature = 0.7,
            Messages = new[]
            {
                new ChatMessage
                {
                    Role = "user",
                    Content = "Привет чатик"
                }
            }
        };
        var result = await openAi.ChatEndpoint.GetChatCompletions(sendObject);
        Assert.True(result.IsSuccess);
    }
}