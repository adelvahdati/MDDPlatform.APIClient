using MDDPlatform.APIClient.Dtos.PatternInstanceTemplates;
using MDDPlatform.APIClient.Services.Rest;

namespace MDDPlatform.APIClient.Services.PatternInstanceTemplates;
public class PatternInstanceTemplateService : IPatternInstanceTemplateService
{
    private readonly IRestClient _restClient;

    public PatternInstanceTemplateService(HttpClient httpClient)
    {
        _restClient = new RestClient(httpClient);
    }

    public async Task CreatePatternInstanceTemplateAsync(Guid patternInstanceId, string title, string name)
    {
        var request = new {
            PatternInstanceId = patternInstanceId,
            TemplateName = name,
            TemplateTitle = title
        };
        string url = "PatternInstanceTemplate";
        await _restClient.PostAsync(url,request);
    }

    public async Task<PatternInstanceTemplateDto?> GetPatternInstanceTemplateAsync(Guid patternInstanceTemplateId)
    {
        string url = string.Format("PatternInstanceTemplate/{0}",patternInstanceTemplateId);
        return await _restClient.GetAsync<PatternInstanceTemplateDto?>(url);

    }

    public async Task<List<PatternInstanceTemplateDto>> GetPatternSpecificTemplateAsync(Guid PatternId)
    {
        string url = string.Format("PatternInstanceTemplate/Pattern/{0}",PatternId);
        var templates  = await _restClient.GetAsync<List<PatternInstanceTemplateDto>>(url);
        if(Equals(templates,null))
            return new List<PatternInstanceTemplateDto>();

        return templates;
    }

    public async Task<List<PatternInstanceTemplateDto>> ListPatternInstanceTemplatesAsync()
    {
        string url = "PatternInstanceTemplate";
        var templates  = await _restClient.GetAsync<List<PatternInstanceTemplateDto>>(url);
        if(Equals(templates,null))
            return new List<PatternInstanceTemplateDto>();

        return templates;

    }
}
