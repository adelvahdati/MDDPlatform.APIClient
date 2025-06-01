namespace MDDPlatform.APIClient.Dtos.Domains
{
    public class ModelDto : IComparable<ModelDto>
    {
        public Guid Id {get;set;}
        public string Name { get;set; }
        public string Tag { get;set; }
        public string Type {get;set;}
        public int Level {get;set;}
        public ModelLanguageDto Language {get;set;}
        
        public ModelDto(Guid id, string name, string tag, string type, int level,ModelLanguageDto language)
        {
            Id = id;
            Name = name;
            Tag = tag;
            Type = type;
            Level = level;
            Language = language;

        }

        public int CompareTo(ModelDto? other)
        {
            if(other == null)
                return 1;

            if(this.Type != other.Type)
            {
                var thisIndex = GetTypePositionIndex(this.Type);
                var otherIndex = GetTypePositionIndex(other.Type);
                if(thisIndex<otherIndex)
                    return -1;
                else if(thisIndex>otherIndex)
                    return 1;
                else
                    return 0;
            }                
            
            if(this.Level<other.Level)
                return -1;
            else if(this.Level>other.Level)
                return 1;
            else
                return string.Compare(this.Name,other.Name);
            
        }

        private int GetTypePositionIndex(string type)
        {
            if(type.ToLower().Trim() == "cim")
                return 1;
            if(type.ToLower().Trim() == "pim")
                return 2;
            if(type.ToLower().Trim() == "psm")
                return 3;
            if(type.ToLower().Trim() == "code")
                return 4;
            
            return -1;
        }
    }
}