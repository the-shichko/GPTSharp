using GPTSharp.Client;

namespace GPTSharp.Endpoints;

/// <summary>
/// Базовый ендпоинт API | Base enpoint class API
/// </summary>
public abstract class Endpoint
{
    protected Endpoint(string token, IRequestService requestService)
    {
        _requestService = requestService;
        Token = token;
    }

    protected readonly IRequestService _requestService;
    
    /// <summary>
    /// Версия API | Version of API
    /// </summary>
    private const string Version = "v1";
    
    /// <summary>
    /// Базовый url openAI | Base url of openAi
    /// </summary>
    private const string BaseUrl = "https://api.openai.com";
    
    /// <summary>
    /// Конбинация базового url и версии API | Compination of base url and version of API
    /// </summary>
    protected const string BaseUrlVersion = $"{BaseUrl}/{Version}";
    
    /// <summary>
    /// Ключ API | API Key
    /// </summary>
    protected string Token { get; }
}