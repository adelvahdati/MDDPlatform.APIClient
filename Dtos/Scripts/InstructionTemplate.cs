using System.Text.RegularExpressions;

namespace MDDPlatform.APIClient.Dtos.Scripts;
public abstract class InstructionTemplate
{
    public string InstructionCode { get; }
    public string InstructionExpression { get; }
    public string ParametersExpression { get; }
    public string InstructionHint { get; }

    protected Dictionary<int,string> FixedArguments;
    protected InstructionTemplate(string instructionCode, string instructionExpression, string parametersExpression, string instructionHint,Dictionary<int,string> fixedArguments)
    {
        InstructionCode = instructionCode;
        InstructionExpression = instructionExpression;
        ParametersExpression = parametersExpression;
        InstructionHint = instructionHint;
        FixedArguments = fixedArguments;
    }
    public bool FilterOption(string searchValue)
    {
        if(InstructionCode.Contains(searchValue,StringComparison.CurrentCultureIgnoreCase))
            return true;
        
        var expr = string.Format("{0}(",InstructionCode);
        if(searchValue.StartsWith(expr))
        {
            
            var parameters = searchValue.Replace(expr,"");
            var arguments = parameters.Split(",");
            int argsNo = arguments.Count();
            bool isMatched = true;
            for(int i=0; i<argsNo-1;i++)
            {
                if(FixedArguments.ContainsKey(i) && FixedArguments[i].ToLower()!= arguments[i].ToLower())
                    isMatched = false;
            }
            var lastIndex = argsNo-1;
            var lastArguments = arguments[lastIndex];
            if(FixedArguments.ContainsKey(lastIndex) && !FixedArguments[lastIndex].Contains(lastArguments,StringComparison.CurrentCultureIgnoreCase))
                isMatched = false;
            
            return isMatched;
        }
        return false;
    }
    public InstructionDto ToInstruction(string inputText)
    {
        if (!Regex.IsMatch(inputText, InstructionExpression))
            throw new Exception("Invalid Instruction ...");
        
        var instructionMatch = Regex.Match(inputText, InstructionExpression).Value;
        var paramsMatch = Regex.Match(instructionMatch, ParametersExpression).Value;
        var arguments = paramsMatch.Length > 2 ?
                                    paramsMatch.Substring(1, paramsMatch.Length - 2).Split(",").ToList() :
                                    new List<string>();

        return new InstructionDto(InstructionCode, arguments);
    }
}