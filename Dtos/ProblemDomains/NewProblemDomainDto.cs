namespace MDDPlatform.APIClient.Dtos.ProblemDomains; 
public class NewProblemDomainDto
{
    public string Title { get; set; }
    public string Description { get; set; }

    public NewProblemDomainDto(string title, string description)
    {
        Title = title;
        Description = description;
    }
}
