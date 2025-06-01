namespace MDDPlatform.APIClient.Dtos.Languages
{
    public class NewLanguageDto {
        
        public string Name {get; set;}
        public string Version {get;set;}
        public List<ElementDto> Elements {get;set;}

        public NewLanguageDto(string name, string version, List<ElementDto> elements)
        {
            Name = name;
            Version = version;
            Elements = elements;
        }
    }
}