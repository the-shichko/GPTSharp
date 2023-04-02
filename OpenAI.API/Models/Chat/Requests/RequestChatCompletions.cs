using Newtonsoft.Json;

namespace OpenAI.API.Models.Chat.Requests;

[Serializable]
public class RequestChatCompletions
{
    public string Model { get; set; }
    public IEnumerable<ChatMessage> Messages { get; set; }
    public double Temperature { get; set; }
    public int N { get; set; } = 1;
    [JsonProperty("max_tokens")] public int? MaxTokens { get; set; }
}