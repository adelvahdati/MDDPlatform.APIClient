namespace MDDPlatform.APIClient.Notifications.DomainModel;
public class DomainModelUpdated
{
    public Guid DomainId {get;set;}
    public Guid DomainModelId {get;set;}
    public string Name {get;set;}
    public string Type {get;set;}
    public string Tag {get;set;}
    public EventPayload Payload {get;set;}

    public DomainModelUpdated(Guid domainId, Guid domainModelId, string name, string type, string tag, EventPayload payload)
    {
        DomainId = domainId;
        DomainModelId = domainModelId;
        Name = name;
        Type = type;
        Tag = tag;
        Payload = payload;
    }
}