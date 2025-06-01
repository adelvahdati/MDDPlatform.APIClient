
namespace MDDPlatform.APIClient.Dtos.Domains;
public class DomainModelInfo
{
    public Guid Id {get;set;}
    public string Name { get;set; }
    public string Tag { get;set; }
    public string Type {get;set;}
    public int Level {get;set;}
    public Guid DomainId {get;set;}
    public ModelLanguageDto Language {get;set;}
    public DomainModelInfo(Guid id, string name, string tag, string type, int level,Guid domainId,ModelLanguageDto language)
    {
        Id = id;
        Name = name;
        Tag = tag;
        DomainId = domainId;
        Type = type;
        Level = level;
        Language = language;
    }

}
