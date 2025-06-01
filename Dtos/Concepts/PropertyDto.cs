namespace MDDPlatform.APIClient.Dtos.Concepts;
public class PropertyDto
{
    public string Name { get; set; }
    public string Type { get; set; }

    public PropertyDto(string name, string type)
    {
        Name = name;
        Type = type;
    }
}
