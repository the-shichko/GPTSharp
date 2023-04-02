using OpenAI.API.Client;
using OpenAI.API.Models;
using OpenAI.API.Models.Chat.Requests;
using OpenAI.API.Models.Chat.Responses;

namespace OpenAI.API.Endpoints;

/// <summary>
/// Сервис для работы с ендпонтом Chat | Service for work with controller Chat
/// </summary>
public class ChatEndpoint : Endpoint
{
    public ChatEndpoint(string token, IRequestService requestService) : base(token, requestService)
    {
    }
    
    private const string Name = $"{BaseUrlVersion}/chat";

    #region Endpoints

    /// <summary>
    /// Url для получения "Завершений" | Url for getting completions
    /// </summary>
    private const string ChatCompletionsUrl = $"{Name}/completions";

    #endregion

    /// <summary>
    /// Получение завершений | Getting chat completions
    /// </summary>
    /// <param name="chatCompletions">Параметр </param>
    /// <returns></returns>
    public async Task<ResponseResult<CompletionsResult>> GetChatCompletions(RequestChatCompletions chatCompletions)
    {
        return await _requestService.Post<CompletionsResult>(ChatCompletionsUrl, chatCompletions, Token);
    }
}