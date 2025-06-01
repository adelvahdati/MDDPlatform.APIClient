using System.Text;
using Microsoft.AspNetCore.Components;

namespace MDDPlatform.APIClient.Shared;
public partial class NamespaceDeclaration
{
    [Parameter]
    public string Namespace {get;set;}

    private string ToText(){
        StringBuilder builder = new StringBuilder();
        
        builder.AppendFormat("namespace {0};",Namespace);
        builder.AppendLine();
        return builder.ToString();
    }
    public static Dictionary<string,object> GetParameters( string @namespace)
    {
        var parameters = new Dictionary<string,object>();
        parameters.Add(nameof(Namespace),@namespace);
        return parameters;
    }
    public static Type? GetComponentType(){
        return Type.GetType("MDDPlatform.APIClient.Shared.NamespaceDeclaration");
    }


}