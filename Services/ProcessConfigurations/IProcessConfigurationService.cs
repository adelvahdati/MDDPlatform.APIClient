using MDDPlatform.APIClient.Dtos.ProcessConfigurations;

namespace MDDPlatform.APIClient.Services.ProcessConfigurations;
public interface IProcessConfigurationService
{
    Task CreateProcessConfigurationAsync(NewProcessConfigurationDto newProcessConfiguration);
    Task UpdateProcessConfigurationAsync(Guid processConfigurationId);
    Task ConfigTaskAsync(NewTaskConfigurationDto newTaskConfiguration);
    Task ConfigMultipleTaskAsync(MultipleTaskConfigurationDto multipleTaskConfigurations);
    Task<ProcessConfigurationDto?> GetProcessConfigurationAsync(Guid configurationId);
    Task<List<ProcessConfigurationDto>?> GetProcessConfigurationsAsync(Guid processId);
    Task<List<ProcessConfigurationDto>?> ListProcessConfigurationsAsync();
}