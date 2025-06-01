namespace MDDPlatform.APIClient.Dtos.ProcessConfigurations;
public class MultipleTaskConfigurationDto
{
    public Guid ProcessConfigurationId {get;set;}
    public List<TaskConfigDto> TaskConfigs {get;set;}

    public MultipleTaskConfigurationDto(Guid processConfigurationId, List<TaskConfigDto> taskConfigs)
    {
        ProcessConfigurationId = processConfigurationId;
        TaskConfigs = taskConfigs;
    }
}