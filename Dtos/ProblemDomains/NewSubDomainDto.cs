namespace MDDPlatform.APIClient.Dtos.ProblemDomains; 
public class NewSubDomainDto
{
    public string Name { get; set; }
    public Guid ProblemDomainId {get;set;}

    public NewSubDomainDto(string name, Guid problemDomainId)
    {
        Name = name;
        ProblemDomainId = problemDomainId;
    }
}
