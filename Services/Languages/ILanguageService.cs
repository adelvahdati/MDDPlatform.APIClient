using MDDPlatform.APIClient.Dtos.Concepts;
using MDDPlatform.APIClient.Dtos.Languages;

namespace MDDPlatform.APIClient.Services.Languages;
public interface ILanguageService
{
    //Command
    Task CreateLanguage(string name,string version);
    Task CreateLanguage(NewLanguageDto language);
    Task DeleteLanguageAsync(Guid languageId);
    Task AddLanguageElementAsync(Guid languageId,Guid conceptId);
    Task RemoveLanguageElementAsync(Guid languageId,Guid elementId);

    //Query
    Task<ElementDto?> FindLanguageElementAsync(Guid languageId,string name,string type);
    Task<ConceptDto?> GetLanguageConceptAsync(Guid languageId, Guid elementId);
    Task<List<ConceptDto>?> GetLanguageConceptsAsync(Guid languageId);
    Task<LanguageDto?> GetLanguageAsync(Guid languageId);
    Task<LanguageDetailDto?> GetLanguageDetailAsync(Guid languageId);
    Task<List<LanguageDto>> GetLanguagesAsync();
    Task<List<LanguageDto>?> FindLanguagesAsync(string keywords);

    // Seeds
    Task ImportDSLsAsync();
    
}