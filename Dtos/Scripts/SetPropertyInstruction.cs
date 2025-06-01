
namespace MDDPlatform.APIClient.Dtos.Scripts;
public class SetPropertyInstruction : InstructionTemplate
{
    public SetPropertyInstruction(string instructionCode, string instructionExpression, string parametersExpression, string instructionHint, Dictionary<int,string> fixedArguments) 
            : base(instructionCode, instructionExpression, parametersExpression, instructionHint,fixedArguments)
    {
    }
    public static InstructionTemplate Create(string instanceType, string propertyName)
    {
        var instructionCode="SetProperty";
        //var instructionExpression = $"SetProperty\\({instanceType}\\,\\w+\\,{propertyName}\\,\\w+\\)";
        var instructionExpression = $"SetProperty\\({instanceType}\\,\\w+\\,{propertyName}\\,((\\w+|\\W*)+)\\)";
        var parametersExpression = $"\\({instanceType}\\,\\w+\\,{propertyName}\\,((\\w+|\\W*)+)\\)";
        var instructionHint = $"SetProperty({instanceType},INSTANCE_NAME,{propertyName},PROPERTY_VALUE)";

        var fixedArguments = new Dictionary<int,string>();
        fixedArguments.Add(0,instanceType);
        fixedArguments.Add(2,propertyName);
        
        return new SetPropertyInstruction(instructionCode,instructionExpression,parametersExpression,instructionHint,fixedArguments);
    }

}
