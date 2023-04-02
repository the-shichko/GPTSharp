namespace GPTSharp.Models.AiModels.Responses;

public class AiModelsResult
{
    public string Object { get; set; }
    public IEnumerable<AiModelItemResult> Data { get; set; }
}