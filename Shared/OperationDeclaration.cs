using System.Text;
using MDDPlatform.APIClient.Dtos.DomainConcepts;
using Microsoft.AspNetCore.Components;

namespace MDDPlatform.APIClient.Shared;
public partial class OperationDeclaration
{
    [Parameter]
    public string Visibility {get;set;} = "public";
    [Parameter]
    public List<AttributeDto> Attributes { get; set; } = new();
    [Parameter]
    public string Name {get;set;} = "";
    [Parameter]
    public OperationOutput Output {get;set;} = new();
    [Parameter]
    public List<OperationInput> Inputs {get;set;} = new();
    [Parameter]
    public string Body {get;set;} = "";
    // private string ToText()
    // {
    //     StringBuilder  builder = new StringBuilder($"{Visibility} ");
    //     string output = Output.IsCollection == true? $"List<{Output.Type}>" : Output.Type;
    //     builder.Append($"{output} ");
    //     builder.Append($"{Name}");
        
    //     var inputs = Inputs.Select(input=> $"{input.Type} {input.Name}").ToList();
    //     var inputParameters = string.Join(",",inputs);
    //     builder.AppendFormat("({0})",inputParameters);
    //     builder.AppendLine();
    //     builder.Append("{");
    //     builder.AppendLine();        
    //     if(string.IsNullOrEmpty(Body))
    //         builder.Append("throw new NotImplementedException();");
    //     else
    //         builder.Append(Body);
        
    //     builder.AppendLine();
    //     builder.Append("}");
    //     builder.AppendLine();
    //     return builder.ToString();
    // }
    private string ToText()
    {
        string output = Output.IsCollection == true? $"List<{Output.Type}>" : Output.Type;
        var inputs = Inputs.Select(input=> $"{input.Type} {input.Name}").ToList();
        var inputParameters = string.Join(",",inputs);

        // StringBuilder  builder = new StringBuilder($"{Visibility} ");
        StringBuilder  builder = new StringBuilder("");
        builder.AppendFormat("{0} {1} {2}({3})",Visibility,output,Name,inputParameters);
        builder.AppendLine();
        builder.AppendLine("{");

        StringBuilder operationBody;
        if(string.IsNullOrEmpty(Body))
            operationBody = new StringBuilder("throw new NotImplementedException();");
        else
            operationBody = new StringBuilder(Body);
        
        builder.AppendIndented(operationBody.ToString());        
        builder.AppendLine("}");
        return builder.ToString();
    }
    public static Dictionary<string,object> GetParameteres(OperationDto operation)
    {
        var parameters = new Dictionary<string,object>();
        parameters.Add(nameof(Visibility),"public");
        parameters.Add(nameof(Attributes), operation.Attributes);
        parameters.Add(nameof(Name),operation.Name);
        parameters.Add(nameof(Output),operation.Output);
        parameters.Add(nameof(Inputs),operation.Inputs);
        parameters.Add(nameof(Body),"");
        return parameters;
    }
    public static Type? GetComponentType(){
        return Type.GetType("MDDPlatform.APIClient.Shared.OperationDeclaration");
    }
}