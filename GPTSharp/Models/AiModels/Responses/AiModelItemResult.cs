using Newtonsoft.Json;

namespace GPTSharp.Models.AiModels.Responses;

public class AiModelItemResult
{
    public string Id { get; set; }
    public string Object { get; set; }
    [JsonProperty("owned_by")] public string OwnedBy { get; set; }

    [JsonProperty("permission")] public IEnumerable<PermissionResult> Permissions { get; set; }

    public string Root { get; set; }
    public object Parent { get; set; }
}

public class PermissionResult
{
    public string Id { get; set; }
    public string Object { get; set; }
    public long Created { get; set; }
    [JsonProperty("allow_create_engine")] public bool AllowCreateEngine { get; set; }
    [JsonProperty("allow_sampling")] public bool AllowSampling { get; set; }
    [JsonProperty("allow_logprobs")] public bool AllowLogprobs { get; set; }
    [JsonProperty("allow_search_indices")] public bool AllowSearchIndices { get; set; }
    [JsonProperty("allow_view")] public bool AllowView { get; set; }
    [JsonProperty("allow_fine_tuning")] public bool AllowFineTuning { get; set; }
    public string Organization { get; set; }
    public string Group { get; set; }
    [JsonProperty("is_blocking")] public bool IsBlocking { get; set; }
}