namespace MDDPlatform.APIClient.Dtos.Processes;
public class TaskTemplateDto
{
    public string Title {get;set;}
    public TaskType Type {get;set;}
    public Guid TemplateId {get;set;}

    public TaskTemplateDto(string title, TaskType type, Guid templateId)
    {
        Title = title;
        Type = type;
        TemplateId = templateId;
    }
}