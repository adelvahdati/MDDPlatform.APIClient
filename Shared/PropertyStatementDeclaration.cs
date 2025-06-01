using System.Text;
using MDDPlatform.APIClient.Dtos.DomainConcepts;
using Microsoft.AspNetCore.Components;

namespace MDDPlatform.APIClient.Shared;
public partial class PropertyStatementDeclaration
{
    [Parameter]
    public string PropertyName {get; set;}="";
    [Parameter]
    public string PropertyType {get;set;}="";
    [Parameter]
    public bool IsCollection {get;set;} = false;
    [Parameter]
    public string? Value {get;set;}
    [Parameter]
    public bool IsReadOnly {get;set;} = false;
    [Parameter]
    public string ProeprtySetVisibility {get;set;} = "";
    [Parameter]
    public List<AttributeDto> Attributes {get;set;} = new();
    private string ToText(){
        StringBuilder builder = new StringBuilder();
        string propertyType,propertyValue;
        if(IsCollection)
            propertyType = string.Format("List<{0}>",PropertyType);
        else
            propertyType = PropertyType;

        
        if(IsReadOnly)
        {
            builder.AppendFormat("public {0} {1}",propertyType,PropertyName);
            builder.Append(" {get;}");
        }
        else if(ProeprtySetVisibility == "private" || ProeprtySetVisibility =="protected")
        {
            builder.AppendFormat("public {0} {1}",propertyType,PropertyName);
            builder.Append(" {get;");
            builder.AppendFormat("{0} set;",ProeprtySetVisibility);
            builder.Append("}");
        }            
        else
        {
            builder.AppendFormat("public {0} {1}",propertyType,PropertyName);
            builder.Append(" {get; set;}");
        }                                    
        if(Value!=null)
        {
            propertyValue = PropertyType.Contains("string",StringComparison.OrdinalIgnoreCase)? string.Format("\"{0}\"",Value) : Value;
            builder.AppendFormat(" = {0}",propertyValue);
        }
            

        builder.AppendLine();
        Console.WriteLine(builder.ToString());
        return builder.ToString();
    }
    public static Dictionary<string,object> GetParameters(PropertyDto proeprty)
    {
        var parameters = new Dictionary<string,object>();
        parameters.Add(nameof(PropertyName),proeprty.Name);
        parameters.Add(nameof(PropertyType),proeprty.Type);
        parameters.Add(nameof(IsCollection),proeprty.IsCollection);
        if(proeprty.Value!=null)
            parameters.Add(nameof(Value),proeprty.Value);
        else
            parameters.Add(nameof(Value),"null");
        
        parameters.Add(nameof(Attributes),proeprty.Attributes);        
        parameters.Add(nameof(IsReadOnly),false);
        parameters.Add(nameof(ProeprtySetVisibility),"public");        
        return parameters;

    }
    public static Type? GetComponentType(){
        return Type.GetType("MDDPlatform.APIClient.Shared.PropertyStatementDeclaration");
    }

}