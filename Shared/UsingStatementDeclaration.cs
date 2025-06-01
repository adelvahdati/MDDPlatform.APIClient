using System.Text;
using Microsoft.AspNetCore.Components;

namespace MDDPlatform.APIClient.Shared;
public partial class UsingStatementDeclaration
{
    [Parameter]
    public string UsingStatement {get;set;}
    
    private string ToText()
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendFormat("using {0};",UsingStatement);
        builder.AppendLine();
        return builder.ToString();
    }
    public static Dictionary<string,object> GetParameters( string usingStatement)
    {
        var parameters = new Dictionary<string,object>();
        parameters.Add(nameof(UsingStatement),usingStatement);
        return parameters;
    }
    public static Type? GetComponentType(){
        return Type.GetType("MDDPlatform.APIClient.Shared.UsingStatementDeclaration");
    }

}