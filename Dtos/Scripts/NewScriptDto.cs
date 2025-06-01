namespace MDDPlatform.APIClient.Dtos.Scripts;
public class NewScriptDto
{
    public string Title {get; set;}
    public List<InstructionDto> Instructions {get; set;}
    public Guid DomainModelId {get;set;}
    public NewScriptDto(string title, List<InstructionDto> instructions,Guid domainModelId)
    {
        Title = title;
        Instructions = instructions;
        DomainModelId = domainModelId;
    }
}