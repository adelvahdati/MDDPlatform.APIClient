namespace MDDPlatform.APIClient.Dtos.PatternInstances;
public class MemberValueExpression
{
    public string Name { get; set; }
    public string ValueExpression { get; set; }

    public MemberValueExpression(string name, string valueExpression)
    {
        Name = name;
        ValueExpression = valueExpression;
    }
}