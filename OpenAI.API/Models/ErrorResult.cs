namespace OpenAI.API.Models;

public class ErrorResult
{
    public Error Error { get; set; }
}

[Serializable]
public class Error
{
    public string Message { get; set; }
    public string Type { get; set; }
    public string Param { get; set; }
    public string Code { get; set; }
}