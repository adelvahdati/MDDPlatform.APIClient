namespace MDDPlatform.APIClient.Dtos.ProcessConfigurations;
public class  TaskConfigurationDto
{
    public Guid Id {get;set;}
    public string TaskTitle {get; set;}
    public List<TaskParameterValueDto> ParameterValues {get;set;}

    public TaskConfigurationDto(Guid id, string taskTitle, List<TaskParameterValueDto> parameterValues)
    {
        Id = id;
        TaskTitle = taskTitle;
        ParameterValues = parameterValues;
    }
}