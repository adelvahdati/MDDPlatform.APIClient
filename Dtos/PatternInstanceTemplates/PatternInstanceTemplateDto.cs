using MDDPlatform.APIClient.Dtos.Patterns;

namespace MDDPlatform.APIClient.Dtos.PatternInstanceTemplates;
public class PatternInstanceTemplateDto
{
    public Guid Id {get;set;}
    public Guid PatternId {get; set;}
    public string PatternName {get; set;}
    public string PatternCategory {get; set;}
    public string Title {get; set;}
    public string Name {get; set;}
    public List<FieldValueDto> FieldValues {get;set;}
    public List<FieldDto> Variables {get;set;}

    public PatternInstanceTemplateDto(Guid id, Guid patternId, string patternName, string patternCategory, string title, string name, List<FieldValueDto> fieldValues, List<FieldDto> variables)
    {
        Id = id;
        PatternId = patternId;
        PatternName = patternName;
        PatternCategory = patternCategory;
        Title = title;
        Name = name;
        FieldValues = fieldValues;
        Variables = variables;
    }
}