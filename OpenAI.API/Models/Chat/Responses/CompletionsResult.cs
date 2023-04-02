using Newtonsoft.Json;
using OpenAI.API.Models.Chat.Requests;

namespace OpenAI.API.Models.Chat.Responses;

[Serializable]
public class CompletionsResult
{
    public string Id { get; set; }
    public string Object { get; set; }
    public long Created { get; set; }
    public string Model { get; set; }
    public UsageCompletions Usage { get; set; }
    public IEnumerable<ChoiceCompletions> Choices { get; set; }
}

public class UsageCompletions
{
    [JsonProperty("prompt_tokens")] public int PromptTokens { get; set; }
    [JsonProperty("completion_tokens")] public int CompletionTokens { get; set; }
    [JsonProperty("total_tokens")] public int TotalTokens { get; set; }
}

public class ChoiceCompletions
{
    public ChatMessage Message { get; set; }
    [JsonProperty("finish_reason")] public string FinishReason { get; set; }
    public int Index { get; set; }
}