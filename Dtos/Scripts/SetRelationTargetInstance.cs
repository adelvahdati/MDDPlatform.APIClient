namespace MDDPlatform.APIClient.Dtos.Scripts;
public class SetRelationTargetInstance : InstructionTemplate
{
    public SetRelationTargetInstance(string instructionCode, string instructionExpression, string parametersExpression, string instructionHint,Dictionary<int,string> fixedArguments) 
        : base(instructionCode, instructionExpression, parametersExpression, instructionHint,fixedArguments)
    {
    }
    public static InstructionTemplate Create(string instanceType, string relationName,string relationTarget)
    {
        var instructionCode="SetRelationTargetInstance";
        var instructionExpression = $"SetRelationTargetInstance\\({instanceType}\\,\\w+\\,{relationName}\\,{relationTarget}\\,\\w+\\)";
        var parametersExpression = $"\\({instanceType}\\,\\w+\\,{relationName}\\,{relationTarget}\\,\\w+\\)";
        var instructionHint = $"SetRelationTargetInstance({instanceType},INSTANCE_NAME,{relationName},{relationTarget},TARGET_INSTANCE)";

        var fixedArguments = new Dictionary<int,string>();
        fixedArguments.Add(0,instanceType);
        fixedArguments.Add(2,relationName);
        fixedArguments.Add(3,relationTarget);

        return new SetRelationTargetInstance(instructionCode,instructionExpression,parametersExpression,instructionHint,fixedArguments);
    }

}
