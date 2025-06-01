namespace MDDPlatform.APIClient.Dtos.ExecutableProcesses;
public class ExecutableProcessDto
{
    public Guid Id {get;set;}
    public Guid ProcessId {get;set;}    
    public Guid ProcessConfigurationId => Id;
    public ProcessExecutionStatus Status {get;set;}
    public List<TaskInstanceDto> TaskInstances {get;set;}

    public ExecutableProcessDto(Guid id, Guid processId, ProcessExecutionStatus status, List<TaskInstanceDto> taskInstances)
    {
        Id = id;
        ProcessId = processId;
        Status = status;
        TaskInstances = taskInstances;
    }
}
