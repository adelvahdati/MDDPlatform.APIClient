using MDDPlatform.APIClient.Dtos.DomainModels;

namespace MDDPlatform.APIClient.Dtos.Scripts;
public class CreateInstanceInstruction : InstructionTemplate
{
    private CreateInstanceInstruction(string instructionCode,string instructionExpression, string parametersExpression, string instructionHint,Dictionary<int,string> fixedArguments) 
        : base(instructionCode,instructionExpression, parametersExpression, instructionHint,fixedArguments)
    {
    }

    public static InstructionTemplate Create(string instanceType)
    {
        var instructionCode="CreateInstance";
        var instructionExpression = $"CreateInstance\\({instanceType}\\,\\w+\\)";
        var parametersExpression = $"\\({instanceType}\\,\\w+\\)";
        var instructionHint = $"CreateInstance({instanceType},INSTANCE_NAME)";

        var fixedArguments = new Dictionary<int,string>();
        fixedArguments.Add(0,instanceType);


        return new CreateInstanceInstruction(instructionCode,instructionExpression,parametersExpression,instructionHint,fixedArguments);
    }
}