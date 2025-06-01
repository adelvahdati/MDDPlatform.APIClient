namespace MDDPlatform.APIClient.Notifications.DomainModel;
public class EventPayload{
    public ActionType Action {get;set;}
    public Dictionary<string,object?> Result {get;set;}
    public string EventType {get;set;}

    public EventPayload(ActionType action, Dictionary<string, object?> result, string eventType)
    {
        Action = action;
        Result = result;
        EventType = eventType;
    }
}
