using Newtonsoft.Json;

namespace GPTSharp.Models.Chat.Requests;

[Serializable]
public class RequestChatCompletions
{
    public string Model { get; set; }
    public IEnumerable<ChatMessage> Messages { get; set; }
    public double Temperature { get; set; }
    public int N { get; set; } = 1;
    [JsonProperty("max_tokens")] public int? MaxTokens { get; set; }

    /// <summary>
    /// Получение простого объекта для отправки | Getting simple object for send 
    /// </summary>
    /// <param name="message">Сообщение для отправки GPT | Message for sending to GPT</param>
    /// <returns></returns>
    public static RequestChatCompletions SimpleMessage(string message)
    {
        return new RequestChatCompletions
        {
            Messages = new[]
            {
                new ChatMessage
                {
                    Role = "user",
                    Content = message
                }
            },
            Model = "gpt-3.5-turbo",
            Temperature = 0.5,
        };
    }
}