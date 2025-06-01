using MDDPlatform.APIClient.Dtos.Pipelines;

namespace MDDPlatform.APIClient.Services.Pipelines;
public interface IPipelineService
{
    Task CreatePipelineAsync(NewPipelineDto newPipeline);
    Task UpdatePipelineAsync(ModifiedPipeline pipeline);
    Task DeletePipelineAsync(Guid pipelineId);
    Task ExecutePipelineAsync(Guid pipelineId);
    Task RunManualStageAsync(Guid pipelineId,Guid stageId);
    Task AddManualStageAsync(NewStageDto stage);
    Task AddAutomatedStageAsync(NewStageDto stage);
    Task ResetPipelineAsync(Guid pipelineId);
    Task<List<PipelineDto>?> GetPipelinesAsync();
    Task<List<PipelineDto>?> GetProblemDomainPipelinesAsync(Guid problemDomainId);
    Task<PipelineDto?> GetPipelineAsync(Guid pipelineId);
}