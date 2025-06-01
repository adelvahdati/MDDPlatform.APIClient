namespace MDDPlatform.APIClient.Dtos.DomainObjects;
public class UpdateDomainObjectDto
{
    public Guid DomainModelId {get;set;}
    public Guid DomainObjectId {get; set;}    
    public string InstanceName {get;set;}
    public List<DomainObjectPropertyDto> Properties {get;set;}
    public List<RelationDto> Relations {get;set;}
    public List<RelationalDimensionDto> RelationalDimensions {get;set;}

    public UpdateDomainObjectDto(Guid domainModelId, Guid domainObjectId, string instanceName, List<DomainObjectPropertyDto> properties, List<RelationDto> relations, List<RelationalDimensionDto> relationalDimensions)
    {
        DomainModelId = domainModelId;
        DomainObjectId = domainObjectId;
        InstanceName = instanceName;
        Properties = properties;
        Relations = relations;
        RelationalDimensions = relationalDimensions;
    }

    public static UpdateDomainObjectDto Create(Guid domainModelId, DomainObjectDto domainObjectDto)
    {
        var properties = domainObjectDto.Properties
                                            .Select(p=> new DomainObjectPropertyDto(p.Name,p.Value))
                                            .ToList();
        var relations = new List<RelationDto>();
        foreach(var rel in domainObjectDto.Relations){
            foreach(var target in rel.TargetInstances)
            {
                var targetInstanceName = target;
                if(targetInstanceName.Contains("."))
                {
                    targetInstanceName = targetInstanceName.Split(".")[0];
                    Console.WriteLine(targetInstanceName);
                }
                    
                relations.Add(new RelationDto(rel.RelationName,rel.RelationTarget,targetInstanceName));
            }
        }
        return new UpdateDomainObjectDto(domainModelId,domainObjectDto.Id,domainObjectDto.InstanceName,properties,relations,domainObjectDto.RelationalDimensions);

    }
}