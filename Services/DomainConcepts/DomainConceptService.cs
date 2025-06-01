using MDDPlatform.APIClient.Dtos.DomainConcepts;
using MDDPlatform.APIClient.Dtos.DomainObjects;
using MDDPlatform.APIClient.Services.Rest;

namespace MDDPlatform.APIClient.Services.DomainConcepts;
public class DomainConceptService : IDomainConceptService
{
    private readonly IRestClient _restClient;

    public DomainConceptService(HttpClient httpClient)
    {
        _restClient = new RestClient(httpClient);
    }

    public async Task CreateDomainObjectAsync(NewDomainObjectDto instance)
    {
        string url = "DomainModel/DomainObject/Create";
        await _restClient.PostAsync(url,instance);
    }

    public async Task<DomainConceptDto?> GetDomainConceptByIdAsync(Guid domainModelId, Guid domainConceptId)
    {
        string url = string.Format("DomainModel/{0}/DomainConceptId/{1}",domainModelId,domainConceptId);
        return await _restClient.GetAsync<DomainConceptDto?>(url);
    }

    public async Task RemoveDomainObjectAsync(Guid domainModelId,Guid domainObjectId)
    {
        string url = string.Format("DomainModel/{0}/Instance/{1}",domainModelId,domainObjectId);
        await _restClient.DeleteAsync(url);
    }
}