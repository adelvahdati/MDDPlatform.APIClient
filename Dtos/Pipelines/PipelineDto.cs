namespace MDDPlatform.APIClient.Dtos.Pipelines;
public class PipelineDto{
    public Guid Id {get;set;}
    public string Title {get;set;}
    public List<PipelineStageDto> Stages {get;set;}
    public PipelineStatus Status {get;set;}
    public Guid ProblemDomainId {get;set;}

    public PipelineDto(Guid id, string title, List<PipelineStageDto> stages, PipelineStatus status,Guid problemDomainId)
    {
        Id = id;
        Title = title;
        Stages = stages;
        Status = status;
        ProblemDomainId = problemDomainId;
    }
    public void DeleteStage(PipelineStageDto stage){
        Stages.Remove(stage);
    }
    public void AddAutomatedStage(string title,Guid taskId)
    {
        var stage = new PipelineStageDto(Guid.Empty,title,taskId,StageType.Automatic,StageStatus.Ready,DateTime.UtcNow.Ticks);
        Stages.Add(stage);
    }
    public void AddManualStage(string title, Guid taskId = default){
        var stage = new PipelineStageDto(Guid.Empty,title,taskId,StageType.Manual,StageStatus.Ready,DateTime.UtcNow.Ticks);
        Stages.Add(stage);
    }


}