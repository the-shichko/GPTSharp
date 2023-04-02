using System.Net;

namespace OpenAI.API.Models;

[Serializable]
public class ResponseResult<T>
{
    private ResponseResult(HttpStatusCode code, T resutObject)
    {
        StatusCode = code;
        SuccessResult = resutObject;
    }
    
    private ResponseResult(HttpStatusCode code, ErrorResult error)
    {
        StatusCode = code;
        ErrorResult = error;
    }

    public static ResponseResult<T> Success(HttpStatusCode code, T resutObject)
    {
        return new ResponseResult<T>(code, resutObject);
    }
    
    public static ResponseResult<T> Error(HttpStatusCode code, ErrorResult error)
    {
        return new ResponseResult<T>(code, error);
    }

    public bool IsSuccess => StatusCode == HttpStatusCode.OK;
    public HttpStatusCode StatusCode { get; set; }
    public T SuccessResult { get; set; }
    public ErrorResult ErrorResult { get; set; }
}