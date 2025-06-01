using MDDPlatform.APIClient.Dtos.ExecutableProcesses;

namespace MDDPlatform.APIClient.Services.ExecutableProcesses;
public interface IExecutableProcessService
{
    Task CreateAsync(Guid processId,Guid processConfigurationId);
    Task RunAsync(Guid processConfigurationId);
    Task ResetExecutableProcessAsync(Guid processConfigurationId);
    Task RunManualTask(Guid processConfigurationId, Guid taskId);
    Task<ExecutableProcessDto?> GetAsync(Guid processConfigurationId);
}