using MDDPlatform.APIClient.Dtos.PlantUMLs;
using MDDPlatform.APIClient.Services.Rest;

namespace MDDPlatform.APIClient.Services.PlantUMLs;
public class PlantUMLService : IPlantUMLService
{
    private readonly IRestClient _restClient;

    public PlantUMLService(HttpClient httpClient)
    {
        _restClient = new RestClient(httpClient);
    }

    public async Task<DiagramDto?> GetClassDiagramAsync(Guid domainModelId)
    {
        string url = string.Format("/PlantUML/ClassDiagram/{0}",domainModelId);
        return  await _restClient.GetAsync<DiagramDto>(url);
    }

    public async Task<DiagramDto?> GetObjectDiagramAsync(Guid domainModelId)
    {
        string url = string.Format("/PlantUML/ObjectDiagram/{0}",domainModelId);
        return  await _restClient.GetAsync<DiagramDto>(url);        
    }
}
