namespace MDDPlatform.APIClient.Dtos.DomainModels;
public class ConceptDto : IComparable<ConceptDto>{
    public Guid Id {get;set;}
    public string Name { get; set;}
    public string Type { get; set;}

    public ConceptDto(Guid id, string name, string type)
    {
        Id = id;
        Name = name;
        Type = type;
    }
    public string GetFullName(){
        return string.Format("{0}.{1}",Name,Type);
    }

    public int CompareTo(ConceptDto? other)
    {
        if(other == null)
            return 1;
        
        return string.Compare(this.Name,other.Name);
    }
}