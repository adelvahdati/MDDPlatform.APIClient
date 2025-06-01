using MDDPlatform.APIClient.Dtos.Patterns;

namespace MDDPlatform.APIClient.Dtos.Processes;
public class TaskParameterDto
{
    public string Label {get;set;}
    public string Name {get; set;}    
    public FieldType Type {get;set;}

    public TaskParameterDto(string label, string name, FieldType type)
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