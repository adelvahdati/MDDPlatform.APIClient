using MDDPlatform.APIClient.Dtos.PlantUMLs;

namespace MDDPlatform.APIClient.Services.PlantUMLs;
public interface IPlantUMLService
{
    Task<DiagramDto?> GetObjectDiagramAsync(Guid domainModelId);
    Task<DiagramDto?> GetClassDiagramAsync(Guid domainModelId);
}