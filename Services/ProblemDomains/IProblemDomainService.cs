
using MDDPlatform.APIClient.Dtos.ProblemDomains;

namespace MDDPlatform.APIClient.Services.ProblemDomains; 
public interface IProblemDomainService
{
    Task CreateProblemDomainAsync(NewProblemDomainDto problemDomain);
    Task DecomposeProblemDomainAsync(NewSubDomainDto subDomain);
    Task<IEnumerable<ProblemDomainDto>?> GetProblemDomainsAsync();
    Task<ProblemDomainDto?> GetProblemDomainAsync(Guid ProblemDomainId);
    Task<IEnumerable<SubDomainDto>?> GetSubDomainsAsync(Guid ProblemDomainId);
    Task<SubDomainDto?> GetSubDomainByNameAsync(Guid problemDomainId,string subdomain);
    Task DeleteProblemDomainAsync(Guid id);
    Task DeleteSubDomainAsync(Guid problemDomainId,Guid domainId);
}
