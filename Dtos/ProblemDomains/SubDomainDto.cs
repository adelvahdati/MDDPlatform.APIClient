namespace MDDPlatform.APIClient.Dtos.ProblemDomains;
public class SubDomainDto 
{
    public Guid Id {get;set;}
    public string Name { get; set; }

    public SubDomainDto(Guid id,string name)
    {
        Id=id;
        Name = name;
    }
}
