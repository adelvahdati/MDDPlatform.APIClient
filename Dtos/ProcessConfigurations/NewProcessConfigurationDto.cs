namespace MDDPlatform.APIClient.Dtos.ProcessConfigurations;
public class NewProcessConfigurationDto
{
    public Guid ProcessId {get;set;}
    public string Title {get;set;}

    public NewProcessConfigurationDto(Guid processId, string title)
    {
        ProcessId = processId;
        Title = title;
    }
}