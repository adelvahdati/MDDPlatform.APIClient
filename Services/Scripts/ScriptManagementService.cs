using MDDPlatform.APIClient.Dtos.Scripts;
using MDDPlatform.APIClient.Services.Rest;

namespace MDDPlatform.APIClient.Services.Scripts;
public class ScriptManagementService : IScriptManagementService
{
    private readonly IRestClient _restClient;

    public ScriptManagementService(HttpClient httpClient)
    {
        _restClient = new RestClient(httpClient);
    }

    public async Task CreateScriptAsync(NewScriptDto script)
    {
        var url = "Script";
        await _restClient.PostAsync(url,script);
    }
    public async Task UpdateScriptAsync(ScriptDto script)
    {
        var url = "Script/Update";
        await _restClient.PostAsync(url,script);

    }
    public async Task DeleteScriptAsync(Guid scriptId)
    {
        var url = $"Script/{scriptId}";
        await _restClient.DeleteAsync(url);
    }

    public async Task<ScriptDto?> GetScriptAsync(Guid scriptId)
    {
        var url = $"Script/{scriptId}";
        return await _restClient.GetAsync<ScriptDto?>(url);
    }

    public async Task<List<ScriptDto>?> ListDomainModelScripts(Guid domainModelId)
    {
        var url = string.Format("Script/List/{0}",domainModelId);
        return await _restClient.GetAsync<List<ScriptDto>>(url);
    }

    public async Task<List<ScriptDto>?> ListScriptsAsync()
    {
        var url = "Script";
        return await _restClient.GetAsync<List<ScriptDto>>(url);
    }

    public async Task RunScriptAsync(Guid scriptId)
    {
        var url = string.Format("Script/Run/{0}",scriptId);
        
        await _restClient.PostAsync(url);
    }

}