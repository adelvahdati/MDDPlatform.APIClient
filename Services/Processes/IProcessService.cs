using MDDPlatform.APIClient.Dtos.Processes;

namespace MDDPlatform.APIClient.Services.Processes;
public interface IProcessService
{
    Task CreateProcessAsync(string title,List<string> phases);
    Task CreatePhaseAsync(Guid processId, string title, List<string> activities);
    Task CreateActivityAsync(Guid processId,Guid phaseId, string title);
    Task CreateActivityFromPipelineAsync(Guid processId,Guid phaseId, Guid pipelineId, string title);
    Task CreateManualTaskAsync(Guid processId,Guid phaseId, Guid activityId, string title);
    Task CreateTaskFromPatternInstanceTemplateAsync(Guid processId,Guid phaseId, Guid activityId,Guid templateId, string title);
    Task CreateTasksAsync(Guid processId,Guid phaseId,Guid activityId,List<TaskTemplateDto> taskTemplates);

    Task<List<ProcessDto>> ListProcessAsync();
    Task<ProcessDto?> GetProcessAsync(Guid processId);
    Task<List<PhaseDto>?> GetPhasesAsync(Guid processId);
    Task<List<ActivityDto>?> GetActivitiesAsync(Guid processId,Guid phaseId);
    Task<List<TaskDto>?> GetTasksAsync(Guid processId, Guid phaseId, Guid activityId);

    Task DeleteProcessAsync(Guid processId);
    Task DeletePhaseAsync(Guid processId,Guid phaseId);
    Task DeleteActivityAsync(Guid processId,Guid phaseId,Guid activityId);
    Task DeleteTaskAsync(Guid processId,Guid phaseId,Guid activityId,Guid taskId);

}