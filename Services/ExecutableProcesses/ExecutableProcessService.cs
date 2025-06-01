using MDDPlatform.APIClient.Dtos.ExecutableProcesses;
using MDDPlatform.APIClient.Services.Rest;

namespace MDDPlatform.APIClient.Services.ExecutableProcesses;
public class ExecutableProcessService : IExecutableProcessService
{
    private readonly IRestClient _restClient;

    public ExecutableProcessService(HttpClient httpClient)
    {
        _restClient = new RestClient(httpClient);
    }

    public async Task CreateAsync(Guid processId, Guid processConfigurationId)
    {
        var request = new {
            ProcessId = processId,
            ProcessConfigurationId = processConfigurationId
        };
        var url = "ExecutableProcess";
        await _restClient.PostAsync(url,request);
    }

    public async Task<ExecutableProcessDto?> GetAsync(Guid processConfigurationId)
    {
        var url = string.Format("ExecutableProcess/{0}",processConfigurationId);
        return await _restClient.GetAsync<ExecutableProcessDto?>(url);
    }

    public async Task ResetExecutableProcessAsync(Guid processConfigurationId)
    {        
        var url = string.Format("ExecutableProcess/{0}/Reset",processConfigurationId);

        await _restClient.PostAsync(url);
    }

    public async Task RunAsync(Guid processConfigurationId)
    {
        var url = string.Format("ExecutableProcess/{0}",processConfigurationId);
        await _restClient.PostAsync(url);
    }

    public async Task RunManualTask(Guid processConfigurationId, Guid taskId)
    {
        var url = string.Format("ExecutableProcess/{0}/ManualTask/{1}/Run",processConfigurationId,taskId);
        await _restClient.PostAsync(url);
    }
}
