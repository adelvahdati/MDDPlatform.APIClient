namespace MDDPlatform.APIClient.Dtos.DomainObjects;
public class RelationDto
{
    public string RelationName { get; set; }
    public string RelationTarget { get; set; }
    public string TargetInstance { get; set; }

    public RelationDto(string relationName, string relationTarget, string targetInstance)
    {
        RelationName = relationName;
        RelationTarget = relationTarget;
        TargetInstance = targetInstance;
    }
}