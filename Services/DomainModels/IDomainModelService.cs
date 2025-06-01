using MDDPlatform.APIClient.Dtos.DomainConcepts;
using MDDPlatform.APIClient.Dtos.DomainModels;
using MDDPlatform.APIClient.Dtos.DomainObjects;

namespace MDDPlatform.APIClient.Services.DomainModels;
public interface IDomainModelService
{
    // Task SetDomainModelLanguageAsync(Guid modelId,Guid languageId);
    Task<DomainModelDto?> GetDomainModelById(Guid domainModelId);
    Task ClearDomainModelAsycn(Guid domainModelId);
    Task ClearConceptBasedModel(Guid domainModelId);
    Task UpdateDomainModelLanguage(Guid domainModelId,Guid languageId);
    Task UpdateDomainObjectAsync(UpdateDomainObjectDto dto);
    Task RemoveDomainConceptAsync(Guid modelId,string name,string type);
    Task ReuseModelAsync(Guid sourceModel,Guid destinationModel);
    Task<DomainObjectDto?> GetDomainObjectByIdAsync(Guid domainModelId,Guid domainObjectId);
    Task<DomainConceptDto?> GetDomainConceptByFullName(Guid domainModelId,string fullname);
    Task<List<DomainConceptDto>?> GetDomainConceptsByFullName(Guid domainModelId,List<string> fullnames);
    Task<DomainModelElementsDto?> GetDomainModelElementsAsync(Guid domainModelId);
}