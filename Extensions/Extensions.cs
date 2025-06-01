using System.Text;
using MDDPlatform.APIClient.Dtos.DomainModels;
using MDDPlatform.APIClient.Dtos.Scripts;

namespace MDDPlatform.APIClient;
public static class Extensions
{
    public static StringBuilder AppendIndented(this StringBuilder sb, string textBlock)
    {
        foreach (var line in textBlock.TrimEnd().Split('\n'))
        {
            if (!string.IsNullOrWhiteSpace(line))
                sb.AppendLine($"\t{line}");
        }
        return sb;
    }

    public static List<InstructionTemplate> AddAutoCompletionInstructions(this List<InstructionTemplate> instructions,ElementDto element)
    {
        InstructionTemplate instruction;
        instruction  = CreateInstanceInstruction.Create(element.FullName);
        instructions.Add(instruction);

        foreach(var prop in element.Properties){
            instruction = SetPropertyInstruction.Create(element.FullName,prop.Name);
            instructions.Add(instruction);
        }
        foreach(var rel in element.Relations){
            instruction = SetRelationTargetInstance.Create(element.FullName,rel.Name,rel.Target);
            instructions.Add(instruction);
        }
        instruction = AddRelationalDimension.Create(element.FullName);
        instructions.Add(instruction);
        return instructions;
    }
    public static string ResolveExpression(this string expression, Dictionary<string,string> keyValues)
    {
        
        string expr = expression;
        var terms = expression.Split('+');        
        foreach(var term in terms)
        {
            if(keyValues.ContainsKey(term))
                expr = expr.Replace(term,keyValues[term]);
        }
        expr = expr.Replace("+","");
        return expr;        
    }
}