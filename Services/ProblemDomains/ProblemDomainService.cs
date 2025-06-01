using MDDPlatform.APIClient.Dtos.ProblemDomains;
using MDDPlatform.APIClient.Services.Rest;

namespace MDDPlatform.APIClient.Services.ProblemDomains;
public class ProblemDomainService : IProblemDomainService
{
    private readonly IRestClient _restClient;

    // public ProblemDomainService(IRestClient restClient)
    // {
    //     _restClient = restClient;
    // }
    public ProblemDomainService(HttpClient httpClient)
    {
        _restClient = new RestClient(httpClient);
    }
    public async Task CreateProblemDomainAsync(NewProblemDomainDto problemDomain)
    {
        string url = "ProblemDomain/Create";
        await _restClient.PostAsync(url,problemDomain);
    }
    public async Task DecomposeProblemDomainAsync(NewSubDomainDto subDomain)
    {
        string url = "ProblemDomain/Decompose";
        await _restClient.PostAsync(url,subDomain);
    }

    public async Task DeleteProblemDomainAsync(Guid problemDomainId)
    {
        var url = string.Format("ProblemDomain/{0}",problemDomainId);
        await _restClient.DeleteAsync(url);
    }

    public async Task DeleteSubDomainAsync(Guid problemDomainId, Guid domainId)
    {
        var url = string.Format("ProblemDomain/{0}/{1}",problemDomainId,domainId);
        await _restClient.DeleteAsync(url);

    }

    public async Task<ProblemDomainDto?> GetProblemDomainAsync(Guid problemDomainId)
    {
        var url = string.Format("ProblemDomain/{0}",problemDomainId);
        return await _restClient.GetAsync<ProblemDomainDto>(url);
    }

    public async Task<IEnumerable<ProblemDomainDto>?> GetProblemDomainsAsync()
    {
        var url = "ProblemDomain";
        return await _restClient.GetAsync<IEnumerable<ProblemDomainDto>>(url);
    }
    public async Task<SubDomainDto?> GetSubDomainByNameAsync(Guid problemDomainId, string subdomain)
    {
        var url = string.Format("ProblemDomain/{0}/SubDomains/{1}",problemDomainId,subdomain);
        return await _restClient.GetAsync<SubDomainDto>(url);
    }
    public async Task<IEnumerable<SubDomainDto>?> GetSubDomainsAsync(Guid problemDomainId)
    {
        var url = string.Format("ProblemDomain/{0}/SubDomains",problemDomainId);
        return await _restClient.GetAsync<IEnumerable<SubDomainDto>>(url);
    }
}