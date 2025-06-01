using MDDPlatform.APIClient.Dtos.Domains;

namespace MDDPlatform.APIClient.Services.Domains;
public interface IDomainService
{
    Task CreateModelAsync(Guid domainId, NewModelDto model);
    Task DeleteModelAsync(Guid domainId,Guid modelId);
    Task<DomainDto?> GetDomainAsync(Guid domainId);
    Task<List<ModelDto>?> GetDomainModelsAsync(Guid domainId);
    Task<List<ModelDto>?> GetProblemDomainModelsAsync(Guid problemdDomainId);
    Task<ModelDto?> FindModelByIdAysnc(Guid domainId,Guid modelId);
    Task<List<ModelDto>?> FindModelsAsync(ModelFilterDto filter);
    Task<DomainModelInfo?> FindDomainModelByIdAsync(Guid id);
    Task<List<DomainModelInfo>?> FindDomainModelsByIdAsync(List<Guid> Ids);
}