namespace MDDPlatform.APIClient.Dtos.ProcessConfigurations;
public class TaskParameterValueDto
{
    public string Name {get; set;}
    public string? Value {get; set;}
    public bool IsConfigured {get;set;}

    public TaskParameterValueDto(string name, string? value, bool isConfigured)
    {
        Name = name;
        Value = value;
        IsConfigured = isConfigured;
    }
}