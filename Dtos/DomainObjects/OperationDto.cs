namespace MDDPlatform.APIClient.Dtos.DomainObjects;
public class OperationDto
{
    public List<OperationInput> Inputs {get;set;}
    public string Name {get;set;}
    public OperationOutput Output {get;set;}

    public OperationDto(List<OperationInput> inputs, string name, OperationOutput output)
    {
        Inputs = inputs;
        Name = name;
        Output = output;
    }
}
public class OperationInput{
    public string Name {get;set;}
    public string Type {get;set;}

    public OperationInput(string name, string type)
    {
        Name = name;
        Type = type;
    }
}
public class OperationOutput
{
    public string Type {get;set;}
    public bool IsCollection {get;set;}

    public OperationOutput(string type, bool isCollection)
    {
        Type = type;
        IsCollection = isCollection;
    }
}