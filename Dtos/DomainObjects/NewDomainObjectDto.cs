namespace MDDPlatform.APIClient.Dtos.DomainObjects;
public class NewDomainObjectDto
{
    public Guid DomainModelId {get;set;}
    public Guid DomainConceptId { get; set;}
    public string InstanceName { get; set;}
    public List<PropertyValueDto> DomainObjectProperties { get; set;}
    public List<RelationTargetInstanceDto> DomainObjectRelations { get; set;}
    public List<RelationalDimensionDto>? RelationalDimensions {get;set;}

    public NewDomainObjectDto(Guid domainModelId, Guid domainConceptId, string instanceName, List<PropertyValueDto> domainObjectProperties, List<RelationTargetInstanceDto> domainObjectRelations,List<RelationalDimensionDto>? relationalDimensions =null)
    {
        DomainModelId = domainModelId;
        DomainConceptId = domainConceptId;
        InstanceName = instanceName;
        DomainObjectProperties = domainObjectProperties;
        DomainObjectRelations = domainObjectRelations;
        RelationalDimensions = relationalDimensions;
    }
}
public class PropertyValueDto
{
    public string Name { get; set; }
    public string Value { get; set; }

    public PropertyValueDto(string name, string value)
    {
        Name = name;
        Value = value;
    }
}
public class RelationTargetInstanceDto
{
    public string RelationName { get; set; }
    public string RelationTarget { get; set; }
    public string TargetInstance { get; set; }

    public RelationTargetInstanceDto(string relationName, string relationTarget, string targetInstance)
    {
        RelationName = relationName;
        RelationTarget = relationTarget;
        TargetInstance = targetInstance;
    }
}

