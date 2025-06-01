using MDDPlatform.APIClient.Dtos.Common;

namespace MDDPlatform.APIClient.Dtos.Processes;
public class PhaseDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public List<ActivityDto> Activities { get; set; }

    public PhaseDto(Guid id, string title, List<ActivityDto> activities)
    {
        Id = id;
        Title = title;
        Activities = activities;
    }
    public Item ToItem()
    {
        return new Item($"Phase : {Title}",Activities.Select(activity=>activity.ToItem()).ToList());
    }

}