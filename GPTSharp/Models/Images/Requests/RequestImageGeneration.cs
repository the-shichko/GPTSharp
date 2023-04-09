namespace GPTSharp.Models.Images.Requests;

[Serializable]
public class RequestImageGeneration
{
    /// <summary>
    /// Текст для генерации в изображение | Text for generation in image
    /// </summary>
    public string Prompt { get; set; }
    /// <summary>
    /// Количество результатов | Result quantity
    /// </summary>
    public int N { get; set; }
    
    /// <summary>
    /// Размер изображений | Size of images
    /// 1024x1024 example
    /// </summary>
    public string Size { get; set; }
}