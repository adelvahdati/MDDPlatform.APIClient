
namespace MDDPlatform.APIClient.Dtos.Patterns;
public class NewPatternInstanceDto
{
    public Guid ProblemDomainId {get;set;}
    public string Title {get; set;}
    public string Name {get; set;}
    public Guid PatternId {get;set;}
    public string PatternName {get;set;}
    public List<FieldValueDto> FieldValues {get;set;}

    public NewPatternInstanceDto(Guid problemDomainId, string title, string name, Guid patternId, string patternName, List<FieldValueDto> fieldValues)
    {
        ProblemDomainId = problemDomainId;
        Title = title;
        Name = name;
        PatternId = patternId;
        PatternName = patternName;
        FieldValues = fieldValues;
    }
    public NewPatternInstanceDto()
    {
        FieldValues = new();
    }
}