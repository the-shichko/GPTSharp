using GPTSharp.Client;
using GPTSharp.Models;
using GPTSharp.Models.AiModels.Responses;

namespace GPTSharp.Endpoints;

/// <summary>
/// Сервис для работы с ендпонтом Models | Service for work with controller Models
/// </summary>
public class ModelEndpoint : Endpoint
{
    public ModelEndpoint(string token, IRequestService requestService) : base(token, requestService)
    {
    }

    private const string Name = $"{BaseUrlVersion}/models";

    #region Endpoints

    /// <summary>
    /// Url для получения "Модели" по Id | Url for getting model by Id
    /// </summary>
    private const string GetByIdUrl = Name + "/{0}";

    #endregion

    /// <summary>
    /// Получение списка доступных моделей | Getting list of available models 
    /// </summary>
    /// <returns></returns>
    public async Task<ResponseResult<AiModelsResult>> GetModels()
    {
        return await _requestService.Get<AiModelsResult>(Name, Token);
    }

    /// <summary>
    /// Получение модели по её Id | Getting model by Id
    /// </summary>
    /// <returns></returns>
    public async Task<ResponseResult<AiModelItemResult>> GetModelById(string id)
    {
        var endpoint = string.Format(GetByIdUrl, id);
        return await _requestService.Get<AiModelItemResult>(endpoint, Token);
    }
}