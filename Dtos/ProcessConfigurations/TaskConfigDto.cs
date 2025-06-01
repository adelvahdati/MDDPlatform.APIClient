using MDDPlatform.APIClient.Dtos.Patterns;

namespace MDDPlatform.APIClient.Dtos.ProcessConfigurations;
public class TaskConfigDto{
    public Guid TaskId {get;set;}
    public List<FieldValueDto> ParameterValues {get;set;}

    public TaskConfigDto(Guid taskId, List<FieldValueDto> parameterValues)
    {
        TaskId = taskId;
        ParameterValues = parameterValues;
    }
}