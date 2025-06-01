using MDDPlatform.APIClient.Dtos.PatternInstances;
using MDDPlatform.APIClient.Dtos.Patterns;

namespace MDDPlatform.APIClient.Services.Patterns;
public interface IPatternService
{
    Task CreatePatternAsync(NewPatternDto pattern);
    Task CreatePatternInstanceAsync (NewPatternInstanceDto instance);
    Task DeletePatternInstanceAsync(Guid instanceId);
    Task<PatternDto?> GetPatternAsync(Guid patternId);
    Task<List<PatternDto>?> ListPatternsAsync();
    Task<PatternInstanceDto?> GetPatternInstanceAsync(Guid instanceId);
    Task<List<PatternInstanceDto>?> ListPatternInstancesAsync(Guid patternId);
    Task<List<PatternInstanceDto>?> ListProblemDomainPatternInstancesAsync(Guid problemDomain);
    Task<List<PatternInstanceInfoDto>?> FindPatternInstancesAsync(PatternInstanceFilterDto filter); 

    // Seed
    Task ImportPatternsAsync();
}