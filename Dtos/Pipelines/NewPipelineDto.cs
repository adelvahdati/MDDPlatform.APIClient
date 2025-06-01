namespace MDDPlatform.APIClient.Dtos.Pipelines;
public class NewPipelineDto{
    public string Title {get;set;}
    public List<StageDto> Stages {get;set;}
    public Guid ProblemDomainId {get;set;}

    public NewPipelineDto(string title, List<StageDto> stages,Guid problemDomainId)
    {
        Title = title;
        Stages = stages;
        ProblemDomainId = problemDomainId;
    }
    public NewPipelineDto(){
        Title = "";
        Stages = new();
        ProblemDomainId = Guid.Empty;
    }
    public void AddAutomatedStage(string title,Guid taskId)
    {
        var stage = new StageDto(title,StageType.Automatic,taskId);
        Stages.Add(stage);
    }
    public void AddManualStage(string title, Guid taskId = default){
        var stage = new StageDto(title,StageType.Manual,taskId);
        Stages.Add(stage);
    }
    public void ClearStages(Guid newProblemDomain)
    {
        ProblemDomainId = newProblemDomain;
        Stages = new();
    }
    public void DeleteStage(StageDto stage){
        Stages.Remove(stage);
    }
}