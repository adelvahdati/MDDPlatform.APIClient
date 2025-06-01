namespace MDDPlatform.APIClient.Dtos.ProblemDomains; 
public class ProblemDomainDto
{
    public Guid Id {get;set;}
    public string Title { get; set; }
    public string Description { get; set; }
    public List<SubDomainDto> SubDomains { get; set; }
    public ProblemDomainDto(Guid id,string title, string description, List<SubDomainDto> subDomains)
    {
        Id = id;
        Title = title;
        Description = description;
        SubDomains = subDomains;
    }
}
