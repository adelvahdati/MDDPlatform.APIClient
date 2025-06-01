namespace MDDPlatform.APIClient.Dtos.Pipelines;

public class ModifiedPipeline
{
    public Guid Id {get; private set;}
    public string Title {get;set;}
    public List<CurrentOrNewStage> Stages {get;private set;}

    private ModifiedPipeline(Guid id, string title, List<CurrentOrNewStage> stages)
    {
        Id = id;
        Title = title;
        Stages = stages;
    }
    public static ModifiedPipeline Initialize(PipelineDto pipeline)
    {
        var stages = pipeline.Stages.Select( st => CurrentOrNewStage.LoadCurrentStage(st)).ToList();
        return new(pipeline.Id,pipeline.Title,stages);
    }
    public void AddAutomatedStage(string title, Guid taskId)
    {
        Stages.Add(CurrentOrNewStage.CreateNewStage(title,taskId,StageType.Automatic));
    }
    public void AddManualStage(string title,Guid taskId = default)
    {
        Stages.Add(CurrentOrNewStage.CreateNewStage(title,taskId,StageType.Manual));
    }
    public void MoveUpStage(CurrentOrNewStage stage)
    {
        int i,n;
        n= Stages.Count;
        if(n==0)
            return;
        
        i=0;
        while(i<n && Stages[i].Id !=stage.Id)
        {
            i=i+1;
        }
        if(i==0 || i==n)
            return;

        var oldStage = Stages[i-1];
        Stages[i-1] = stage;
        Stages[i] = oldStage;

            
    }
    public void MoveDownStage(CurrentOrNewStage stage)
    {
        int i,n;
        n= Stages.Count;
        if(n==0)
            return;
        
        i=0;
        while(i<n && Stages[i].Id !=stage.Id)
        {
            i=i+1;
        }
        if(i==n-1 || i==n)
            return;

        var oldStage = Stages[i+1];
        Stages[i+1] = stage;
        Stages[i] = oldStage;        
    }

    public void DeleteStage(CurrentOrNewStage stage){
        Stages.Remove(stage);
    }

}
public class CurrentOrNewStage 
{
    public Guid Id {get;set;}
    public string Title { get;  set; }
    public Guid TaskId { get;  set; }
    public StageType Type { get; set; }

    private CurrentOrNewStage(Guid id, string title, Guid taskId, StageType type)
    {
        Id = id;
        Title = title;
        TaskId = taskId;
        Type = type;
    }
    private CurrentOrNewStage(string title, Guid taskId, StageType type)
    {
        Id = Guid.NewGuid();
        Title = title;
        TaskId = taskId;
        Type = type;
    }

    public static CurrentOrNewStage CreateNewStage(string title , Guid taskId, StageType type){
        return new(title,taskId,type);
    }
    public static CurrentOrNewStage LoadCurrentStage (PipelineStageDto stage){
        return new CurrentOrNewStage(stage.Id,stage.Title,stage.TaskId,stage.Type);
    }
}