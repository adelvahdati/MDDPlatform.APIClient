namespace MDDPlatform.APIClient.Dtos.DomainObjects;
public class DomainObjectPropertyDto{
    public string Name { get; set; }
    public string Value {get;set;}

    public DomainObjectPropertyDto(string name, string value)
    {
        Name = name;
        Value = value;
    }
}