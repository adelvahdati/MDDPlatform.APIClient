namespace MDDPlatform.APIClient.Dtos.Domains;
public class NewModelDto
{
        public string Name { get;set; }
        public string Tag { get;set; }
        public string Type {get;set;}
        public int Level {get;set;}
        public ModelLanguageDto Language {get;set;}

        public NewModelDto(string name, string tag, string type,int level,ModelLanguageDto language)
        {
            Name = name;
            Tag = tag;
            Type = type;
            Level = level;
            Language = language;
        }
}