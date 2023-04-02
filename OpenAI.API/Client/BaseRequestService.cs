using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using OpenAI.API.Models;

namespace OpenAI.API.Client;

public class BaseRequestService : IRequestService
{
    private readonly HttpClient _client;
    private readonly JsonSerializerSettings _serializerSettings;

    public BaseRequestService()
    {
        _client = new HttpClient();
        
        _serializerSettings = new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver()
        };
    }
    
    /// <summary>
    /// Базовый Get-запрос | Basic get-request
    /// </summary>
    /// <param name="url">Url для запроса | Url for request</param>
    /// <param name="token">Api key</param>
    /// <typeparam name="T">Класс успешного результата | Class of success result</typeparam>
    /// <returns></returns>
    public async Task<ResponseResult<T>> Get<T>(string url, string token = null)
    {
        _client.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", token);
        
        var response = await _client.GetAsync(url);
        var content = await response.Content.ReadAsStringAsync();
        
        if (response.IsSuccessStatusCode)
        {
            var result = JsonConvert.DeserializeObject<T>(content);
            return ResponseResult<T>.Success(response.StatusCode, result);
        }

        var error = JsonConvert.DeserializeObject<ErrorResult>(content);
        return ResponseResult<T>.Error(response.StatusCode, error);
    }

    /// <summary>
    /// Базовый Get-запрос | Basic get-request
    /// </summary>
    /// <param name="url">Url для запроса | Url for request</param>
    /// <param name="sendObject">Объект для отправки в body | Object for send to body</param>
    /// <param name="token">Api key</param>
    /// <typeparam name="T">Класс успешного результата | Class of success result</typeparam>
    /// <returns></returns>
    public async Task<ResponseResult<T>> Post<T>(string url, object sendObject, string token = null)
    {
        var json = JsonConvert.SerializeObject(sendObject, _serializerSettings);
        var data = new StringContent(json, Encoding.UTF8, "application/json");

        _client.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", token);
        
        var response = await _client.PostAsync(url, data);

        var content = await response.Content.ReadAsStringAsync();
        if (response.IsSuccessStatusCode)
        {
            var result = JsonConvert.DeserializeObject<T>(content);
            return ResponseResult<T>.Success(response.StatusCode, result);
        }

        var error = JsonConvert.DeserializeObject<ErrorResult>(content);
        return ResponseResult<T>.Error(response.StatusCode, error);
    }
}