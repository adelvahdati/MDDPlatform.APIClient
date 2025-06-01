namespace MDDPlatform.APIClient.Dtos.Patterns;
public class PatternInstanceDto
{
    public Guid Id {get;set;}
    public string Title {get;private set;}
    public string Name {get;private set;}
    public Guid PatternId {get;set;}
    public string PatternName {get;set;}
    public List<FieldValueDto> FieldValues {get;set;}
    public Guid ProblemDomainId {get;set;}

    public PatternInstanceDto(Guid id, string title, string name, Guid patternId, string patternName, List<FieldValueDto> fieldValues,Guid problemDomainId)
    {
        Id = id;
        Title = title;
        Name = name;
        PatternId = patternId;
        PatternName = patternName;
        FieldValues = fieldValues;
        ProblemDomainId = problemDomainId;
    }
}