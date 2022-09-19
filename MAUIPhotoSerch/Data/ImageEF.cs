namespace MAUIPhotoSerch.Data;

public class ImageEF
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime? DateChange { get; set; } 
    public string Patch { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
}
