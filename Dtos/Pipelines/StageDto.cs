namespace MDDPlatform.APIClient.Dtos.Pipelines;
public class StageDto 
{
    public string Title {get;set;}
    public StageType Type {get;set;} 
    public Guid TaskId {get;set;}

    public StageDto(string title, StageType type, Guid taskId = default(Guid))
    {
        Title = title;
        Type = type;
        TaskId = taskId;
    }
}
