namespace MDDPlatform.APIClient.Dtos.ProcessConfigurations;
public class ProcessConfigurationDto 
{
    public Guid Id {get;set;}
    public Guid ProcessId {get;set;}
    public string Title {get;set;}
    public List<TaskConfigurationDto> TaskConfigurations {get;set;}
    
    public ProcessConfigurationDto(Guid id, Guid processId, string title,List<TaskConfigurationDto> taskConfigurations)
    {
        Id = id;
        ProcessId = processId;
        Title = title;
        TaskConfigurations = taskConfigurations;
    }
}