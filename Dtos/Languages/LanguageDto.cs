namespace MDDPlatform.APIClient.Dtos.Languages
{
    public class LanguageDto {
        public Guid Id {get;set;}
        public string Name {get; set;}
        public string Version {get;set;}
        public List<ElementDto> Elements {get;set;}

        public LanguageDto(Guid id, string name, string version, List<ElementDto> elements)
        {
            Id = id;
            Name = name;
            Version = version;
            Elements = elements;
        }
    }
}