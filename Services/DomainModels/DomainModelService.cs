using System.Text.Json;
using MDDPlatform.APIClient.Dtos.DomainConcepts;
using MDDPlatform.APIClient.Dtos.DomainModels;
using MDDPlatform.APIClient.Dtos.DomainObjects;
using MDDPlatform.APIClient.Services.Rest;

namespace MDDPlatform.APIClient.Services.DomainModels;
public class DomainModelService : IDomainModelService
{
    private readonly IRestClient _restClient;

    public DomainModelService(HttpClient httpClient)
    {
        _restClient = new RestClient(httpClient);
    }

    public async Task ClearConceptBasedModel(Guid domainModelId)
    {
        string url = string.Format("DomainModel/{0}/ConceptBasedModel/Clear",domainModelId);
        await _restClient.PostAsync(url);
    }

    public async Task ClearDomainModelAsycn(Guid domainModelId)
    {
        string url = string.Format("DomainModel/{0}/Clear",domainModelId);
        await _restClient.PostAsync(url);
        
    }

    public async Task<DomainConceptDto?> GetDomainConceptByFullName(Guid domainModelId, string fullname)
    {
        string url = string.Format("DomainModel/{0}/DomainConcept/{1}",domainModelId,fullname);
        return await _restClient.GetAsync<DomainConceptDto?>(url);
    }

    public async Task<List<DomainConceptDto>?> GetDomainConceptsByFullName(Guid domainModelId, List<string> fullnames)
    {
        string url="DomainModel/DomainConcepts/FilterByFullnames";
        var payload = new {
            DomainModelId = domainModelId,
            FullNames = fullnames
        };
        try
        {            
            return await _restClient.PostAsync<List<DomainConceptDto>?>(url,payload);
        }
        catch(Exception ex){
            Console.WriteLine(ex.Message);
            return null;
        }
    }

    public async Task<DomainModelDto?> GetDomainModelById(Guid domainModelId)
    {
        string url = string.Format("DomainModel/{0}",domainModelId);
        return await _restClient.GetAsync<DomainModelDto?>(url);
    }

    public async Task<DomainModelElementsDto?> GetDomainModelElementsAsync(Guid domainModelId)
    {
        string url = string.Format("DomainModel/{0}/Elements",domainModelId);
        return await _restClient.GetAsync<DomainModelElementsDto?>(url);
    }

    public async Task<DomainObjectDto?> GetDomainObjectByIdAsync(Guid domainModelId, Guid domainObjectId)
    {
        string url = string.Format("DomainModel/{0}/DomainObject/{1}",domainModelId,domainObjectId);
        return await _restClient.GetAsync<DomainObjectDto?>(url);
    }

    public async Task RemoveDomainConceptAsync(Guid modelId, string name, string type)
    {
        var payload = new {
            ModelId = modelId,
            Name = name,
            Type = type
        };
        var url = "DomainModel/DomainConcept/Remove";
        await _restClient.PostAsync(url,payload);        
    }

    public async Task ReuseModelAsync(Guid sourceModel, Guid destinationModel)
    {
        string url = "DomainModel/Reuse";
        var command = new {
            Source = sourceModel,
            Destination = destinationModel
        };
        await _restClient.PostAsync(url,command);
    }

    public async Task UpdateDomainModelLanguage(Guid domainModelId, Guid languageId)
    {
        string url = string.Format("DomainModel/{0}/UpdateLanguage/{1}",domainModelId,languageId);
        await _restClient.PostAsync(url);
    }

    public async Task UpdateDomainObjectAsync(UpdateDomainObjectDto dto)
    {
        string url = string.Format("DomainModel/DomainObject/Update");
        await _restClient.PostAsync(url,dto);

    }
}