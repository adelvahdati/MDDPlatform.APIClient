namespace MDDPlatform.APIClient.Dtos.Domains;
public class ModelTemplateDto
{
    public string NameExpression { get;  set; }
    public string TagExpression { get; set; }
    public string Type {get;set;}
    public int Level {get; set;}
    public Guid LanguageId {get; set;}
    public string LanguageName {get;set;}

    public ModelTemplateDto(string nameExpression, string tagExpression, string type, int level, Guid languageId, string languageName)
    {
        NameExpression = nameExpression;
        TagExpression = tagExpression;
        Type = type;
        Level = level;
        LanguageId = languageId;
        LanguageName = languageName;
    }
}
