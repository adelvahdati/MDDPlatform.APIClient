namespace MDDPlatform.APIClient.Dtos.Patterns;
public class FieldDto
{
    public string Label {get;set;}
    public string Name {get; set;}    
    public FieldType Type {get;set;}

    public FieldDto(string label, string name, FieldType type)
    {
        Label = label;
        Name = name;
        Type = type;
    }
    public override string ToString()
    {
        return string.Format("Parameter Name : {0}",Name);
    }
}