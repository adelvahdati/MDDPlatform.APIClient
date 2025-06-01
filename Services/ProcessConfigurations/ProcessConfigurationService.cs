using MDDPlatform.APIClient.Dtos.ProcessConfigurations;
using MDDPlatform.APIClient.Services.Rest;

namespace MDDPlatform.APIClient.Services.ProcessConfigurations;
public class ProcessConfigurationService : IProcessConfigurationService
{
    private readonly IRestClient _restClient;

    public ProcessConfigurationService(HttpClient httpClient)
    {
        _restClient = new RestClient(httpClient);
    }

    public async Task ConfigMultipleTaskAsync(MultipleTaskConfigurationDto multipleTaskConfigurations)
    {
        string url = "ProcessConfiguration/MultipleTask";
        await _restClient.PostAsync(url,multipleTaskConfigurations);

    }

    public async Task ConfigTaskAsync(NewTaskConfigurationDto newTaskConfiguration)
    {
        string url = "ProcessConfiguration/Task";
        await _restClient.PostAsync(url,newTaskConfiguration);
    }

    public async Task CreateProcessConfigurationAsync(NewProcessConfigurationDto newProcessConfiguration)
    {
        string url = "ProcessConfiguration";
        await _restClient.PostAsync(url,newProcessConfiguration);
    }
    public async Task UpdateProcessConfigurationAsync(Guid processConfigurationId)
    {
        string url = string.Format("ProcessConfiguration/Update/{0}",processConfigurationId);
        await _restClient.PostAsync(url);
    }


    public async Task<ProcessConfigurationDto?> GetProcessConfigurationAsync(Guid configurationId)
    {
        string url = string.Format("ProcessConfiguration/{0}",configurationId);
        return await _restClient.GetAsync<ProcessConfigurationDto?>(url);
    }

    public async Task<List<ProcessConfigurationDto>?> GetProcessConfigurationsAsync(Guid processId)
    {
        string url = string.Format("ProcessConfiguration/Process/{0}",processId);
        return await _restClient.GetAsync<List<ProcessConfigurationDto>?>(url);
    }

    public async Task<List<ProcessConfigurationDto>?> ListProcessConfigurationsAsync()
    {
        string url = "ProcessConfiguration";
        return await _restClient.GetAsync<List<ProcessConfigurationDto>?>(url);
    }
}
