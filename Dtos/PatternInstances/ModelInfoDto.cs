namespace MDDPlatform.APIClient.Dtos.PatternInstances;
public class ModelInfoDto
{
    public Guid Id {get;set;}
    public string Name { get; set; }
    public string Type { get; set; }
    public Guid LanguageId {get; set;}
    public string LaguageName {get;  set;}
    public bool IsBuiltin {get;set;}

    public override string ToString()
    {
        return $"{Name} - Type : {Type} - Language : {LaguageName}";
    }
}