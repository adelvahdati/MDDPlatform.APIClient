namespace MDDPlatform.APIClient.Dtos.DomainConcepts;
public class DomainConceptDto
{
    public Guid Id {get;set;}
    public Guid DomainId {get;set;}
    public Guid ConceptId {get;set;}
    public string Name {get;set;}
    public string Type {get;set;}
    public List<InstanceDto> Instances {get;set;}
    public List<PropertyDto> Properties {get;set;}
    public List<RelationDto> Relations {get;set;}
    public  List<OperationDto> Operations {get;set;}
    public List<AttributeDto> Attributes {get;set;}

    public string FullName => string.Format("{0}.{1}",Name,Type);

    public DomainConceptDto(Guid id, Guid domainId, Guid conceptId, string name, string type, List<InstanceDto> instances, List<PropertyDto> properties, List<RelationDto> relations, List<OperationDto> operations,List<AttributeDto> attributes = null)
    {
        Id = id;
        DomainId = domainId;
        ConceptId = conceptId;
        Name = name;
        Type = type;
        Instances = instances;
        Properties = properties;
        Relations = relations;
        Operations = operations;
        Attributes = attributes == null ? new() : attributes;
    }
    public DomainConceptDto(){
        Id = Guid.Empty;
        DomainId = Guid.Empty;
        ConceptId = Guid.Empty;
        Name = String.Empty;
        Type = string.Empty;
        Instances =new();
        Properties = new();
        Relations = new();
        Operations = new();
        Attributes = new();
    }
}