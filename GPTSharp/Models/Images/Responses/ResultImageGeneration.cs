namespace GPTSharp.Models.Images.Responses;

[Serializable]
public class ResultImageGeneration
{
    public long Created { get; set; }
    
    public IEnumerable<ResultImageUrl> Data { get; set; }
}

[Serializable]
public class ResultImageUrl
{
    public string Url { get; set; }
}