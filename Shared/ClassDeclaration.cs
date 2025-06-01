using System.Text;
using MDDPlatform.APIClient.Dtos.DomainConcepts;
using MDDPlatform.APIClient.Dtos.DomainModels;
using Microsoft.AspNetCore.Components;

namespace MDDPlatform.APIClient.Shared;
public partial class ClassDeclaration
{
    [Parameter]
    public string Namespace {get;set;}

    [Parameter]
    public List<string> UsingStatements {get;set;}

    [Parameter]
    public string Name {get;set;}

    [Parameter]
    public string Extend {get;set;}

    [Parameter]
    public List<string> Realize {get;set;}

    [Parameter]
    public string Visibility {get;set;}

    [Parameter]
    public bool IsAbstract {get;set;}

    [Parameter]
    public bool IsStatic {get;set;}

    [Parameter]
    public List<AttributeDto> Attributes { get; set; }

    [Parameter]
    public List<PropertyDto> Properties {get;set;}
    
    [Parameter]
    public List<OperationDto> Operations {get;set;}

    private string StartClassDeclaration()
    {
        StringBuilder builder = new StringBuilder();
        
        List<string> extendAndRealized = new();
        if(!string.IsNullOrEmpty(Extend))
            extendAndRealized.Add(Extend);
        if(Realize.Count>0)
            extendAndRealized.AddRange(Realize);
        
        string staticOrAbstractClass="class";

        if(IsStatic && !IsAbstract)
            staticOrAbstractClass = "static class";
        if(IsAbstract && !IsStatic)
            staticOrAbstractClass = "abstract class";
        
        builder.AppendFormat("{0} {1} {2}",Visibility,staticOrAbstractClass,Name);
        
        if(extendAndRealized.Count>0)
        {
            string imp = string.Join(",",extendAndRealized);
            builder.AppendFormat(" : {0}",imp);
        }
        builder.AppendLine();
        builder.Append("{");
        builder.AppendLine();

        return builder.ToString();

    }
    private string EndClassDeclaration()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append("}");
        builder.AppendLine();
        return builder.ToString();
    }
    public static Dictionary<string,object> GetParameters(ElementDto element)
    {
        var parameters = new Dictionary<string,object>();
        parameters.Add(nameof(Namespace),ExtractNamespace(element));
        parameters.Add(nameof(UsingStatements),ExtractUsingStatements(element));
        parameters.Add(nameof(Name),element.Name);
        parameters.Add(nameof(Extend),ExtractsupperClass(element));
        parameters.Add(nameof(Realize),ExtractRealizedInterface(element));
        parameters.Add(nameof(Visibility),ExtractVisibility(element));
        parameters.Add(nameof(IsAbstract),IsAbstractClass(element));
        parameters.Add(nameof(IsStatic),IsStaticClass(element));
        parameters.Add(nameof(Attributes),ExtractAttributeProperties(element));
        parameters.Add(nameof(Properties),element.Properties);
        parameters.Add(nameof(Operations),element.Operations);        
        return parameters;
    }

    private static List<string> ExtractRealizedInterface(ElementDto element)
    {
        var realizedInterfaceAttribute = element.Attributes.Where(attr=>attr.Name.ToLower() == "realize")
                                                        .FirstOrDefault();
        
        if(realizedInterfaceAttribute == null)
            return new();
        
        if(string.IsNullOrEmpty(realizedInterfaceAttribute.Value))
            return new();

        var result = realizedInterfaceAttribute.Value.Split(",");

        return result.ToList();        

    }

    private static string ExtractsupperClass(ElementDto element)
    {
        var supperClassAttribute = element.Attributes.Where(attr=>attr.Name.ToLower() == "extend")
                                                        .FirstOrDefault();
        if(supperClassAttribute== null)                                                    
            return "";
        return supperClassAttribute.Value;
    }

    private static List<AttributeDto> ExtractAttributeProperties(ElementDto element)
    {
        List<string> excludeAttributes = new List<string>(){"namespace","isstatic","isabstract","visibility","extend","realize","using"};
        return element.Attributes.Where(attr=> !excludeAttributes.Contains(attr.Name.ToLower()))
                                    .ToList();
    }

    private static bool IsStaticClass(ElementDto element)
    {
        bool status;
        var isStaticAttribute = element.Attributes.Where(attr=>attr.Name .ToLower()=="IsStatic".ToLower())
                                                    .FirstOrDefault();
        if(isStaticAttribute == null)
            return false;

        var result =  bool.TryParse(isStaticAttribute.Value, out status);
        if(result)
            return status;
        
        return false;
    }

    private static bool IsAbstractClass(ElementDto element)
    {
        bool status;
        var abstractionStatus = element.Attributes.Where(attr=>attr.Name .ToLower()=="IsAbstract".ToLower())
                                                    .FirstOrDefault();
        if(abstractionStatus == null)
            return false;

        var result =  bool.TryParse(abstractionStatus.Value, out status);
        if(result)
            return status;
        
        return false;
    }

    private static string ExtractVisibility(ElementDto element)
    {
        string DefaultVisibility = "public";
        var visibility = element.Attributes.Where(attr=>attr.Name.ToLower() == "visibility")
                                            .FirstOrDefault();
        
        if(visibility == null)
            return DefaultVisibility;
        
        return visibility.Value;        
    }

    public static Type? GetComponentType(){
        return Type.GetType("MDDPlatform.APIClient.Shared.ClassDeclaration");
    }
    private static string ExtractNamespace(ElementDto element)
    {
        var namespaceAttribute =  element.Attributes.Where(attr=>attr.Name.ToLower() == "namespace")
                                            .FirstOrDefault();

        if(namespaceAttribute == null)
            return "";

        return namespaceAttribute.Value;
    }
    private static List<string> ExtractUsingStatements(ElementDto element)
    {
        return element.Attributes.Where(attr=>attr.Name.ToLower()=="using")
                            .SelectMany(attr=>attr.Value.Split(","))
                            .ToList();
    }

}
