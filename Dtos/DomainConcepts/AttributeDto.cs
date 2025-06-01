namespace MDDPlatform.APIClient.Dtos.DomainConcepts;
public class AttributeDto
{
    public string Name { get; set;}
    public string Value { get; set;}

    public AttributeDto(string name, string value)
    {
        Name = name;
        Value = value;
    }
}