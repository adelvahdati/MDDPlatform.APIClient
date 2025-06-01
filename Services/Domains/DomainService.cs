using MDDPlatform.APIClient.Dtos.Domains;
using MDDPlatform.APIClient.Services.Rest;

namespace MDDPlatform.APIClient.Services.Domains;
public class DomainService : IDomainService
{
    private readonly IRestClient _restClient;

    public DomainService(HttpClient httpClient)
    {
        _restClient = new RestClient(httpClient);
    }


    public async Task CreateModelAsync(Guid domainId, NewModelDto model)
    {
        string url = string.Format("Domain/{0}/Model/Create",domainId);
        await _restClient.PostAsync(url,model);
    }

    public async Task DeleteModelAsync(Guid domainId, Guid modelId)
    {
        string url = string.Format("Domain/{0}/Model/{1}",domainId,modelId);
        await _restClient.DeleteAsync(url);
    }

    public async Task<DomainModelInfo?> FindDomainModelByIdAsync(Guid id)
    {
        string url = string.Format("Domain/DomainModel/{0}",id);
        return await _restClient.GetAsync<DomainModelInfo?>(url);
    }

    public async Task<List<DomainModelInfo>?> FindDomainModelsByIdAsync(List<Guid> Ids)
    {
        string url = "Domain/DomainModels";
        var request = new {
            ModelIds = Ids
        };
        return await _restClient.PostAsync<List<DomainModelInfo>?>(url,request);
    }

    public async Task<ModelDto?> FindModelByIdAysnc(Guid domainId, Guid modelId)
    {
        string url = string.Format("Domain/{0}/Model/{1}",domainId,modelId);
        return await _restClient.GetAsync<ModelDto>(url);
    }

    public async Task<List<ModelDto>?> FindModelsAsync(ModelFilterDto filter)
    {
        var url = "Domain/Find";
        return await _restClient.PostAsync<List<ModelDto>?>(url,filter);
    }

    public async Task<DomainDto?> GetDomainAsync(Guid domainId)
    {
        string url = string.Format("Domain/{0}",domainId);
        return await _restClient.GetAsync<DomainDto>(url);

    }

    public async Task<List<ModelDto>?> GetDomainModelsAsync(Guid domainId)
    {
        string url = string.Format("Domain/{0}/Models",domainId);
        return await _restClient.GetAsync<List<ModelDto>>(url);

    }

    public async Task<List<ModelDto>?> GetProblemDomainModelsAsync(Guid problemdDomainId)
    {
        string url = string.Format("Domain/ProblemDomainModels/{0}",problemdDomainId);
        return await _restClient.GetAsync<List<ModelDto>>(url);
    }
}
