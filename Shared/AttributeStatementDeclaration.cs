using System.Text;
using MDDPlatform.APIClient.Dtos.DomainConcepts;
using Microsoft.AspNetCore.Components;

namespace MDDPlatform.APIClient.Shared;
public partial class AttributeStatementDeclaration
{
    [Parameter]
    public string AttributeName {get;set;}
    [Parameter]
    public string AttributeValue {get;set;}

    public string ToText()
    {
        StringBuilder builder = new StringBuilder();
        if(AttributeValue == "")
        {
            builder.AppendFormat("[{0}]",AttributeName);
            builder.AppendLine();
        }            
        else
        {
            builder.AppendFormat("[{0}(\"{1}\")]",AttributeName,AttributeValue);
            builder.AppendLine();
        }
        return builder.ToString();
    }
    public static Dictionary<string,object> GetParameters(AttributeDto attribute)
    {
        var parameters = new Dictionary<string,object>();
        parameters.Add(nameof(AttributeName), attribute.Name);
        parameters.Add(nameof(AttributeValue), attribute.Value);
        return parameters;
    }
    public static Type? GetComponentType(){
        return Type.GetType("MDDPlatform.APIClient.Shared.AttributeStatementDeclaration");
    }
}