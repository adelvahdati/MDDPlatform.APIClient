using MDDPlatform.APIClient.Dtos.Codes;
using MDDPlatform.APIClient.Services.Rest;

namespace MDDPlatform.APIClient.Services.Transformations;
public class TransformationService : ITransformationService
{
    private readonly IRestClient _restClient;

    public TransformationService(HttpClient httpClient)
    {
        _restClient = new RestClient(httpClient);        
    }

    public async Task ArchiveProjectAsync(ArchiveProjectCodeRequest request)
    {
        var url = "CodeGenerator/archive";
        await _restClient.PostAsync(url,request);
    }

    public async Task ExecutePatternInstanceAsync(Guid instanceId)
    {
        string url = string.Format("Transformation/PatternInstances/{0}",instanceId);
        await _restClient.PostAsync(url);
    }
}
