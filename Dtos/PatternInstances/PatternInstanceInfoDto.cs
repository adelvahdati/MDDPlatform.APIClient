namespace MDDPlatform.APIClient.Dtos.PatternInstances;
public class PatternInstanceInfoDto
{
    public Guid Id {get;set;}
    public Guid ProblemDomainId {get;set;}
    public Guid PatternId {get;set;}
    public string PatternName {get;set;}
    public string PatternCategory {get;set;}
    public string PatternInstanceTitle {get;set;}
    public List<ModelInfoDto> InputModels {get;set;}
    public List<ModelInfoDto> OutputModels {get;set;}
}