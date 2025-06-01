namespace MDDPlatform.APIClient.Dtos.Pipelines;
public class PipelineStageDto{
    public Guid Id {get;set;}
    public string Title { get;  set; }
    public Guid TaskId { get;  set; }
    public StageType Type { get; set; }
    public StageStatus Status { get;  set; }
    public long SequenceNumber {get; set;}

    public PipelineStageDto(Guid id, string title, Guid taskId, StageType type, StageStatus status, long sequenceNumber)
    {
        Id = id;
        Title = title;
        TaskId = taskId;
        Type = type;
        Status = status;
        SequenceNumber = sequenceNumber;
    }
}