using MDDPlatform.APIClient.Dtos.Codes;
using MDDPlatform.APIClient.Dtos.Patterns;

namespace MDDPlatform.APIClient.Services.Transformations;
public interface ITransformationService
{
    Task ExecutePatternInstanceAsync(Guid instanceId);
    Task ArchiveProjectAsync(ArchiveProjectCodeRequest request);
}