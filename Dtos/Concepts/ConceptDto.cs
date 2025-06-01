namespace MDDPlatform.APIClient.Dtos.Concepts;
public class ConceptDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }

    public List<PropertyDto> Properties { get; set; }
    public List<RelationDto> Relations { get; set; }

    public ConceptDto(Guid id, string name, string type, List<PropertyDto> properties, List<RelationDto> relations)
    {
        Id = id;
        Name = name;
        Type = type;
        Properties = properties;
        Relations = relations;
    }
    public ConceptDto(){
        Id = Guid.Empty;
        Name= "";
        Type = "";
        Properties = new();
        Relations = new();
    }
}
