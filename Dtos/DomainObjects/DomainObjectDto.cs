namespace MDDPlatform.APIClient.Dtos.DomainObjects;
public class DomainObjectDto{
    public Guid Id {get; set;}
    public Guid DomainConceptId {get;set;}
    public string InstanceName {get;set;}
    public string InstanceType {get;set;}
    public List<PropertyDto> Properties {get;set;}
    public List<DomainObjectRelationDto> Relations {get;set;}
    public  List<OperationDto> Operations {get;set;}
    public List<RelationalDimensionDto> RelationalDimensions {get;set;}

    public DomainObjectDto(Guid id, Guid domainConceptId, string instanceName, string instanceType, List<PropertyDto> properties, List<DomainObjectRelationDto> relations, List<OperationDto> operations, List<RelationalDimensionDto> relationalDimensions)
    {
        Id = id;
        DomainConceptId = domainConceptId;
        InstanceName = instanceName;
        InstanceType = instanceType;
        Properties = properties;
        Relations = relations;
        Operations = operations;
        RelationalDimensions = relationalDimensions;
    }
}