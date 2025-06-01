using MDDPlatform.APIClient.Dtos.Patterns;

namespace MDDPlatform.APIClient.Dtos.ProcessConfigurations;
public class NewTaskConfigurationDto
{
    public Guid ProcessConfigurationId {get;set;}
    public Guid TaskId {get;set;}
    public List<FieldValueDto>  ParemeterValues {get;set;}

    public NewTaskConfigurationDto(Guid processConfigurationId, Guid taskId, List<FieldValueDto> paremeterValues)
    {
        ProcessConfigurationId = processConfigurationId;
        TaskId = taskId;
        ParemeterValues = paremeterValues;
    }
}