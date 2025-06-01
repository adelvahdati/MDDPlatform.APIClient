using MDDPlatform.APIClient.Dtos.Processes;

namespace MDDPlatform.APIClient.Dtos.ExecutableProcesses;
public class TaskInstanceDto{
    public Guid Id {get;set;}
    public string Title {get;  set;}
    public TaskType Type {get;  set;}
    public TaskStatus Status {get; set;}
    public List<TaskAttributeDto> Attributes { get;  set; }
    public Guid TemplateId {get;set;}

    public TaskInstanceDto(Guid id, string title, TaskType type, TaskStatus status, List<TaskAttributeDto> attributes, Guid templateId)
    {
        Id = id;
        Title = title;
        Type = type;
        Status = status;
        Attributes = attributes;
        TemplateId = templateId;
    }    
}
