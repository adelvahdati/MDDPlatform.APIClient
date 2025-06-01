namespace MDDPlatform.APIClient.Dtos.Scripts;
public class AddRelationalDimension : InstructionTemplate
{
    public AddRelationalDimension(string instructionCode, string instructionExpression, string parametersExpression, string instructionHint, Dictionary<int,string> fixedArguments) 
        : base(instructionCode, instructionExpression, parametersExpression, instructionHint, fixedArguments)
    {
    }
    public static InstructionTemplate Create(string instanceType)
    {
        var instructionCode="AddRelationalDimension";
        var instructionExpression = $"AddRelationalDimension\\({instanceType}\\,\\w+\\,\\w+\\,(\\w+(\\W?))+\\)";
        var parametersExpression = $"\\({instanceType}\\,\\w+\\,\\w+\\,(\\w+(\\W?))+\\)";
        var instructionHint = $"AddRelationalDimension({instanceType},INSTANCE_NAME,RELATION_NAME,RELATION_TARGET)";

        var fixedArguments = new Dictionary<int,string>();
        fixedArguments.Add(0,instanceType);

        return new AddRelationalDimension(instructionCode,instructionExpression,parametersExpression,instructionHint,fixedArguments);
    }

}