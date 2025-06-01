using MDDPlatform.APIClient.Dtos.Processes;
using MDDPlatform.APIClient.Services.Rest;

namespace MDDPlatform.APIClient.Services.Processes;
public class ProcessService : IProcessService
{
    private readonly IRestClient _restClient;

    public ProcessService(HttpClient httpClient)
    {
        _restClient = new RestClient(httpClient);
    }
    public async Task CreateProcessAsync(string title, List<string> phases)
    {
        var request = new {
            Title = title,
            Phases = phases
        };
        var url = "Process";
        await _restClient.PostAsync(url,request);
    }
    public async Task CreatePhaseAsync(Guid processId, string title, List<string> activities)
    {
        var url = "Process/Phase";
        var request = new {
            ProcessId = processId,
            Title = title,
            Activities = activities
        };
        await _restClient.PostAsync(url,request);
    }

    public async Task CreateActivityAsync(Guid processId, Guid phaseId, string title)
    {
        var url = "Process/Phase/Activity";
        var request = new {
            ProcessId = processId,
            PhaseId = phaseId,
            Title = title
        };
        await _restClient.PostAsync(url,request);
    }

    public async Task CreateManualTaskAsync(Guid processId, Guid phaseId, Guid activityId, string title)
    {
        var url = "Process/Phase/Activity/ManualTask";
        var request = new 
        {
            ProcessId = processId,
            PhaseId = phaseId,
            ActivityId = activityId,
            Title = title,
        };
        await _restClient.PostAsync(url,request);
    }

    public async Task CreateTaskFromPatternInstanceTemplateAsync(Guid processId, Guid phaseId, Guid activityId, Guid templateId, string title)
    {
        var url = "Process/Phase/Activity/PatternInstanceExecutionTask";
        var request = new{
            ProcessId = processId,
            PhaseId = phaseId,
            ActivityId = activityId,
            TemplateId = templateId,
            Title = title,
        };
        await _restClient.PostAsync(url,request);
    }
    public async Task CreateTasksAsync(Guid processId, Guid phaseId, Guid activityId, List<TaskTemplateDto> taskTemplates)
    {
        var url = "Process/Phase/Activity/Task";
        var request = new {
            ProcessId = processId,
            PhaseId = phaseId,
            ActivityId = activityId,
            TaskTemplates = taskTemplates
        };
        await _restClient.PostAsync(url,request);        
    }

    public async Task<List<ActivityDto>?> GetActivitiesAsync(Guid processId, Guid phaseId)
    {
        var url = string.Format("Process/{0}/Phase/{1}",processId,phaseId);
        return await _restClient.GetAsync<List<ActivityDto>?>(url);
    }

    public async Task<List<PhaseDto>?> GetPhasesAsync(Guid processId)
    {
        var url = string.Format("Process/{0}/Phases",processId);
        return await _restClient.GetAsync<List<PhaseDto>?>(url);
    }

    public async Task<ProcessDto?> GetProcessAsync(Guid processId)
    {
        var url = string.Format("Process/{0}",processId);
        return await _restClient.GetAsync<ProcessDto?>(url);
    }

    public async Task<List<TaskDto>?> GetTasksAsync(Guid processId, Guid phaseId, Guid activityId)
    {
        var url = string.Format("Process/{0}/Phase/{1}/Activity/{2}",processId,phaseId,activityId);
        return await _restClient.GetAsync<List<TaskDto>?>(url);
    }

    public async Task<List<ProcessDto>> ListProcessAsync()
    {
        var url = "Process";
        var processes =  await _restClient.GetAsync<List<ProcessDto>>(url);
        if(Equals(processes,null))
            return new();

        return processes;
    }

    public async Task CreateActivityFromPipelineAsync(Guid processId, Guid phaseId, Guid pipelineId, string title)
    {
        var url = "Process/Phase/Activity/Pipeline";
        var request = new {
            ProcessId = processId,
            PhaseId = phaseId,
            PipelineId = pipelineId,
            Title = title
        };
        await _restClient.PostAsync(url,request);
    }

    public async Task DeleteProcessAsync(Guid processId)
    {
        var url = string.Format("Process/{0}",processId);
        await _restClient.DeleteAsync(url);
    }

    public async Task DeletePhaseAsync(Guid processId, Guid phaseId)
    {
        var url = string.Format("Process/{0}/Phase/{1}",processId,phaseId);
        await _restClient.DeleteAsync(url);
    }

    public async Task DeleteActivityAsync(Guid processId, Guid phaseId, Guid activityId)
    {
        var url = string.Format("Process/{0}/Phase/{1}/Activity/{2}",processId,phaseId,activityId);
        await _restClient.DeleteAsync(url);
    }

    public async Task DeleteTaskAsync(Guid processId, Guid phaseId, Guid activityId, Guid taskId)
    {
        var url = string.Format("Process/{0}/Phase/{1}/Activity/{2}/Task/{3}",processId,phaseId,activityId,taskId);
        await _restClient.DeleteAsync(url);
    }
}

