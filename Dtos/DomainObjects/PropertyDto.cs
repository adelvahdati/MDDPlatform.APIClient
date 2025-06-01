namespace MDDPlatform.APIClient.Dtos.DomainObjects;
public class PropertyDto{
    public string Name { get; set; }
    public string Type { get; set; }
    public string? Value { get; set; }

    public PropertyDto(string name, string type, string? value)
    {
        Name = name;
        Type = type;
        Value = value;
    }
}