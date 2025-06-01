namespace MDDPlatform.APIClient.Dtos.Scripts;
public class InstructionDto
{
    public string Code { get; set; }
    public List<string> Arguments { get; set; }

    public InstructionDto(string code, List<string> arguments)
    {
        Code = code;
        Arguments = arguments;
    }
    public override string ToString()
    {
        return string.Format("{0}({1})",Code, string.Join(",",Arguments));
    }
}