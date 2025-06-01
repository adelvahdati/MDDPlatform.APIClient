using MDDPlatform.APIClient.Dtos.Scripts;

namespace MDDPlatform.APIClient.Services.Scripts;
public interface IScriptManagementService
{
    Task CreateScriptAsync(NewScriptDto script);
    Task DeleteScriptAsync(Guid scriptId);
    Task UpdateScriptAsync(ScriptDto script);
    Task RunScriptAsync(Guid scriptId);
    Task<List<ScriptDto>?> ListScriptsAsync();
    Task<List<ScriptDto>?> ListDomainModelScripts(Guid domainModelId);
    Task<ScriptDto?> GetScriptAsync(Guid scriptId);
}