using GPTSharp.Client;
using GPTSharp.Models;
using GPTSharp.Models.Images.Requests;
using GPTSharp.Models.Images.Responses;

namespace GPTSharp.Endpoints;

public class ImagesEndpoint : Endpoint
{
    public ImagesEndpoint(string token, IRequestService requestService) : base(token, requestService)
    {
    }

    private const string Name = $"{BaseUrlVersion}/images";

    #region Endpoints

    /// <summary>
    /// Url для получения "Сгенерированных изображений" | Url for getting generations images
    /// </summary>
    private const string PostGenerations = Name + "/generations";

    #endregion

    public async Task<ResponseResult<ResultImageGeneration>> Generations(RequestImageGeneration requestImageGeneration)
    {
        return await _requestService.Post<ResultImageGeneration>(PostGenerations, requestImageGeneration, Token);
    }

    public async Task<ResponseResult<ResultImageGeneration>> Generations(string text, int n)
    {
        var requestImageGeneration = new RequestImageGeneration
        {
            Prompt = text,
            N = n,
            Size = "1024x1024"
        };
        return await _requestService.Post<ResultImageGeneration>(PostGenerations, requestImageGeneration, Token);
    }
}