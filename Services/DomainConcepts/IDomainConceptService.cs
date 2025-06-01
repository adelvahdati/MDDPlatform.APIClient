

using MDDPlatform.APIClient.Dtos.DomainConcepts;
using MDDPlatform.APIClient.Dtos.DomainObjects;

namespace MDDPlatform.APIClient.Services.DomainConcepts;
public interface IDomainConceptService
{
    Task CreateDomainObjectAsync(NewDomainObjectDto instance);
    Task RemoveDomainObjectAsync(Guid domainModelId, Guid domainObjectId);
    Task<DomainConceptDto?> GetDomainConceptByIdAsync(Guid domainModelId, Guid domainConceptId);
}