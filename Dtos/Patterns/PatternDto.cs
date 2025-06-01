namespace MDDPlatform.APIClient.Dtos.Patterns;
public class PatternDto : IComparable<PatternDto>
{
    public Guid Id {get;set;}
    public string Name {get;set;}
    public string Category { get; set; }

    public string? Description {get;set;}
    public List<FieldDto> Fields {get; set;}

    public PatternDto(Guid id,string name,string category, string? description, List<FieldDto> fields)
    {
        Id = id;
        Name = name;
        Category = category;
        Description = description;
        Fields = fields;
    }

    public int CompareTo(PatternDto? other)
    {
        if(other == null)
            return 1;

        if(this.Category != other.Category)
            return string.Compare(this.Category,other.Category);
        
        return string.Compare(this.Name,other.Name);
    }
}