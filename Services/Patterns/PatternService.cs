using MDDPlatform.APIClient.Dtos.PatternInstances;
using MDDPlatform.APIClient.Dtos.Patterns;
using MDDPlatform.APIClient.Services.Rest;

namespace MDDPlatform.APIClient.Services.Patterns;
public class PatternService : IPatternService
{
    private readonly IRestClient _restClient;

    public PatternService(HttpClient httpClient)
    {
        _restClient = new RestClient(httpClient);
    }

    public async Task CreatePatternAsync(NewPatternDto pattern)
    {
        string url = "Pattern";
        await _restClient.PostAsync(url,pattern);
    }

    public async Task CreatePatternInstanceAsync(NewPatternInstanceDto instance)
    {
        string url = "Pattern/Instance";
        await  _restClient.PostAsync(url,instance);
    }

    public async Task DeletePatternInstanceAsync(Guid instanceId)
    {
        string url = string.Format("Pattern/Instance/{0}",instanceId);
        await _restClient.DeleteAsync(url);
    }

    public async Task<PatternDto?> GetPatternAsync(Guid patternId)
    {
        string url = string.Format("Pattern/{0}",patternId);
        return await _restClient.GetAsync<PatternDto?>(url);
    }

    public async Task<PatternInstanceDto?> GetPatternInstanceAsync(Guid instanceId)
    {
        string url = string.Format("Pattern/Instance/{0}",instanceId);
        return await _restClient.GetAsync<PatternInstanceDto?>(url);
    }

    public async Task<List<PatternInstanceDto>?> ListPatternInstancesAsync(Guid patternId)
    {
        string url = string.Format("Pattern/{0}/Instances",patternId);
        return await _restClient.GetAsync<List<PatternInstanceDto>>(url);
    }

    public async Task<List<PatternDto>?> ListPatternsAsync()
    {
        string url = "Pattern";
        return await _restClient.GetAsync<List<PatternDto>?>(url);
    }

    public async Task<List<PatternInstanceDto>?> ListProblemDomainPatternInstancesAsync(Guid problemDomainId)
    {
        string url = $"Pattern/ProblemDomain/{problemDomainId}/PatternInstances";
        return await _restClient.GetAsync<List<PatternInstanceDto>>(url);
    }
    public async Task<List<PatternInstanceInfoDto>?> FindPatternInstancesAsync(PatternInstanceFilterDto filter){
        string url="Pattern/FindPatternInstances";
        return await _restClient.PostAsync<List<PatternInstanceInfoDto>?>(url,filter);
    }

    public async Task ImportPatternsAsync(){
        string url = "Data/Seed";
         await _restClient.PostAsync(url);
    }    
}
