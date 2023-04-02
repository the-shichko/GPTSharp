namespace OpenAI.API.Models.Chat.Requests;

[Serializable]
public class ChatMessage
{
    public string Role { get; set; }
    public string Content { get; set; }
}