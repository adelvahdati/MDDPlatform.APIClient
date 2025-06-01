using MDDPlatform.APIClient.Dtos.PatternInstanceTemplates;

namespace MDDPlatform.APIClient.Services.PatternInstanceTemplates;
public interface IPatternInstanceTemplateService
{
    Task CreatePatternInstanceTemplateAsync(Guid patternInstanceId,string title,string name);
    Task<PatternInstanceTemplateDto?> GetPatternInstanceTemplateAsync(Guid patternInstanceTemplateId);
    Task<List<PatternInstanceTemplateDto>> GetPatternSpecificTemplateAsync(Guid PatternId);
    Task<List<PatternInstanceTemplateDto>> ListPatternInstanceTemplatesAsync();

}
