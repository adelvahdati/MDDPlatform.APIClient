using MDDPlatform.APIClient.Dtos.Concepts;
using MDDPlatform.APIClient.Dtos.Languages;
using MDDPlatform.APIClient.Services.Rest;

namespace MDDPlatform.APIClient.Services.Languages;
public class LanguageService : ILanguageService
{
    private readonly IRestClient restClient;

    // public LanguageService(IRestClient restClient)
    // {
    //     this.restClient = restClient;
    // }
    public LanguageService(HttpClient httpClient)
    {
        this.restClient = new RestClient(httpClient);
    }

    public Task AddLanguageElementAsync(Guid languageId, Guid conceptId)
    {
        var uri = $"Language/{languageId}/AddElement/{conceptId}";
        return restClient.PostAsync(uri);
    }

    public Task CreateLanguage(string name, string version)
    {
        var uri = $"Language/Create/{name}/{version}";
        return restClient.PostAsync(uri);
    }

    public Task CreateLanguage(NewLanguageDto language)
    {
        return restClient.PostAsync("Language/Create",language);
    }

    public Task DeleteLanguageAsync(Guid languageId)
    {
        var uri = $"Language/Delete/{languageId}";
        return restClient.DeleteAsync(uri);
    }

    public Task<ElementDto?> FindLanguageElementAsync(Guid languageId, string name, string type)
    {
        var uri = $"Language/{languageId}/FindElement/{name}/{type}";
        return restClient.GetAsync<ElementDto>(uri);
    }
    public async Task<List<LanguageDto>> GetLanguagesAsync(){
        var uri = $"Language/list";
        var languages = await restClient.GetAsync<List<LanguageDto>>(uri);
        if(languages == null)
            return new List<LanguageDto>();
        
        return languages;
    }
    public Task<LanguageDto?> GetLanguageAsync(Guid languageId)
    {
            var uri = $"Language/{languageId}";
            return restClient.GetAsync<LanguageDto>(uri);
    }

    public Task<ConceptDto?> GetLanguageConceptAsync(Guid languageId, Guid elementId)
    {
        var uri = $"Language/{languageId}/Element/{elementId}";
        return restClient.GetAsync<ConceptDto?>(uri);
        
    }

    public Task<List<ConceptDto>?> GetLanguageConceptsAsync(Guid languageId)
    {
        var uri = $"Language/{languageId}/Elements";
        return restClient.GetAsync<List<ConceptDto>?>(uri);
        
    }

    public Task RemoveLanguageElementAsync(Guid languageId, Guid elementId)
    {
        var uri = $"Language/{languageId}/RemoveElement/{elementId}";
        return restClient.DeleteAsync(uri);
    }

    public async Task<List<LanguageDto>?> FindLanguagesAsync(string keywords)
    {
        var url = "Language/Find";
        var query = new {
            Keywords = keywords
        };
        return await restClient.PostAsync<List<LanguageDto>>(url,query);
    }

    public async Task<LanguageDetailDto?> GetLanguageDetailAsync(Guid languageId)
    {
            var uri = $"Language/{languageId}/Detail";
            return await restClient.GetAsync<LanguageDetailDto>(uri);
    }

    public async Task ImportDSLsAsync()
    {
        var uri = "Data/Seed";
        await restClient.PostAsync(uri);
    }
}