using MDDPlatform.APIClient.Dtos.Concepts;

namespace MDDPlatform.APIClient.Dtos.Languages;
public class LanguageDetailDto
{
        public Guid Id {get;set;}
        public string Name {get; set;}
        public string Version {get;set;}
        public List<ConceptDto> Concepts {get;set;}

    public LanguageDetailDto(Guid id, string name, string version, List<ConceptDto> concepts)
    {
        Id = id;
        Name = name;
        Version = version;
        Concepts = concepts;
    }
}