using MDDPlatform.APIClient.Dtos.Common;

namespace MDDPlatform.APIClient.Dtos.Processes;
public class ActivityDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public List<TaskDto> Tasks {get;set;}

    public ActivityDto(Guid id, string title, List<TaskDto> tasks)
    {
        Id = id;
        Title = title;
        Tasks = tasks;
    }
    public Item ToItem()
    {
        return new Item($"Activity : {Title}",Tasks.Select(task=>task.ToItem()).ToList());
    }
}