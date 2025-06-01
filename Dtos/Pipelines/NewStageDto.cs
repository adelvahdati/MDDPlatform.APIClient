namespace MDDPlatform.APIClient.Dtos.Pipelines;
public class NewStageDto 
{
    public Guid PipelineId {get;set;}
    public string StageTitle {get;set;}
    public Guid TaskId {get;set;}
    public NewStageDto(Guid pipelineId, string stageTitle,Guid taskId = default(Guid))
    {
        PipelineId = pipelineId;
        StageTitle = stageTitle;
        TaskId = taskId;
    }

}