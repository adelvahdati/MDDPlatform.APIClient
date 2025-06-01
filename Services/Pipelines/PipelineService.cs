using MDDPlatform.APIClient.Dtos.Pipelines;
using MDDPlatform.APIClient.Services.Rest;

namespace MDDPlatform.APIClient.Services.Pipelines;
public class PipelineService : IPipelineService
{
    private readonly IRestClient _restClient;

    public PipelineService(HttpClient httpClient)
    {
        _restClient = new RestClient(httpClient);
    }

    public async Task AddAutomatedStageAsync(NewStageDto stage)
    {
        string url = string.Format("Pipeline/{0}/AutomatedStage/Add",stage.PipelineId);
        await _restClient.PostAsync(url,stage);
    }

    public async Task AddManualStageAsync(NewStageDto stage)
    {
        string url = string.Format("Pipeline/{0}/ManualStage/Add",stage.PipelineId);
        await _restClient.PostAsync(url,stage);
    }
    public async Task RunManualStageAsync(Guid pipelineId, Guid stageId)
    {
        string url = string.Format("Pipeline/{0}/ManualStage/Run",pipelineId);
        var request = new
        {
            PipelineId = pipelineId,
            StageId = stageId
        };
        await _restClient.PostAsync(url,request);        
    }

    public async Task CreatePipelineAsync(NewPipelineDto newPipeline)
    {
        string url = "Pipeline";
        await _restClient.PostAsync(url,newPipeline);
    }
    public async Task UpdatePipelineAsync(ModifiedPipeline pipeline)
    {
        string url = "Pipeline/Update";
        await _restClient.PostAsync(url,pipeline);
    }

    public async Task DeletePipelineAsync(Guid pipelineId)
    {
        string url = string.Format("Pipeline/{0}",pipelineId);
        await _restClient.DeleteAsync(url);
    }

    public async Task ExecutePipelineAsync(Guid pipelineId)
    {
        string url = string.Format("Pipeline/{0}/Execute",pipelineId);
        await _restClient.PostAsync(url);
    }

    public async Task<PipelineDto?> GetPipelineAsync(Guid pipelineId)
    {
        string url = string.Format("Pipeline/{0}",pipelineId);
        return await _restClient.GetAsync<PipelineDto?>(url);
    }

    public async Task<List<PipelineDto>?> GetPipelinesAsync()
    {
        string url = "Pipeline";
        return await _restClient.GetAsync<List<PipelineDto>>(url);
    }

    public async Task ResetPipelineAsync(Guid pipelineId)
    {
        string url = string.Format("Pipeline/{0}/Reset",pipelineId);
        await _restClient.PostAsync(url);
    }

    public async Task<List<PipelineDto>?> GetProblemDomainPipelinesAsync(Guid problemDomainId)
    {
        var url = string.Format("Pipeline/ProblemDomain/{0}",problemDomainId);
        return await _restClient.GetAsync<List<PipelineDto>>(url);

    }
}
