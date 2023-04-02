using GPTSharp.Models;

namespace GPTSharp.Client;

public interface IRequestService
{
    /// <summary>
    /// Базовый Get-запрос | Basic get-request
    /// </summary>
    /// <param name="url">Url для запроса | Url for request</param>
    /// <param name="token">Api key</param>
    /// <typeparam name="T">Класс успешного результата | Class of success result</typeparam>
    /// <returns></returns>
    Task<ResponseResult<T>> Get<T>(string url, string token = null);

    /// <summary>
    /// Базовый Get-запрос | Basic get-request
    /// </summary>
    /// <param name="url">Url для запроса | Url for request</param>
    /// <param name="sendObject">Объект для отправки в body | Object for send to body</param>
    /// <param name="token">Api key</param>
    /// <typeparam name="T">Класс успешного результата | Class of success result</typeparam>
    /// <returns></returns>
    Task<ResponseResult<T>> Post<T>(string url, object sendObject, string token = null);
}