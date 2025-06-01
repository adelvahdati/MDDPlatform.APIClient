using MDDPlatform.APIClient.Dtos.Common;

namespace MDDPlatform.APIClient.Dtos.Processes;
public class ProcessDto
{
    public Guid Id {get;set;}
    public string Title {get;set;}
    public List<PhaseDto> Phases {get;set;}

    public ProcessDto(Guid id, string title, List<PhaseDto> phases)
    {
        Id = id;
        Title = title;
        Phases = phases;
    }
    public Item ToItem()
    {
        return new Item($"Process : {Title}",Phases.Select(phase=>phase.ToItem()).ToList());
    }

}
