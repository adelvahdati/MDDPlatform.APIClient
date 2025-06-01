namespace MDDPlatform.APIClient.Dtos.Scripts;
public class ScriptDto
{
    public Guid Id {get;set;}
    public string Title {get; set;}
    public List<InstructionDto> Instructions {get; set;}
    public Guid DomainModelId {get;set;}

    public ScriptDto(Guid id, string title, List<InstructionDto> instructions,Guid domainModelId)
    {
        Id = id;
        Title = title;
        Instructions = instructions;
        DomainModelId = domainModelId;
    }
}