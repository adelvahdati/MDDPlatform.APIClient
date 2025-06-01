namespace MDDPlatform.APIClient.Dtos.Patterns;
public class FieldValueDto
{
    public string Name {get; set;}
    public string Value {get;set;}

    public FieldValueDto(string name, string value)
    {
        Name = name;
        Value = value;
    }
}