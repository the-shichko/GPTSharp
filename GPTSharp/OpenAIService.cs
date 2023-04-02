using GPTSharp.Client;
using GPTSharp.Endpoints;

namespace GPTSharp;

public class OpenAIService
{
    /// <summary>
    /// Сервис для работы с контроллером Chat | Service for work with controller Chat
    /// </summary>
    public readonly ChatEndpoint ChatEndpoint;

    /// <summary>
    /// Сервис для работы с контроллером Models | Service for work with controller Models
    /// </summary>
    public readonly ModelEndpoint ModelsEndpoint;

    /// <summary>
    /// Создание сервиса для работы с openai API | Creating service for work with OpenAI API
    /// </summary>
    /// <param name="token">Ключ API | API key</param>
    public OpenAIService(string token)
    {
        var requestService = new BaseRequestService();
        ChatEndpoint = new ChatEndpoint(token, requestService);
        ModelsEndpoint = new ModelEndpoint(token, requestService);
    }
}