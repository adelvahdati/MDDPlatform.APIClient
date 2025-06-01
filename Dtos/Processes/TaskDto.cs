using MDDPlatform.APIClient.Dtos.Common;

namespace MDDPlatform.APIClient.Dtos.Processes;
public class TaskDto
{
    public Guid Id {get;set;}
    public string Title {get;set;}
    public Guid TaskTemplateId {get;set;}
    public TaskType Type {get;set;}
    public List<TaskParameterDto> Parameters {get;set;}
    public List<TaskAttributeDto> Attributes {get;set;}

    public TaskDto(Guid id, string title, Guid taskTemplateId, TaskType type, List<TaskParameterDto> parameters, List<TaskAttributeDto> attributes)
    {
        Id = id;
        Title = title;
        TaskTemplateId = taskTemplateId;
        Type = type;
        Parameters = parameters;
        Attributes = attributes;
    }

    public Item ToItem()
    {
        List<Item> childrens = new();
        var parameters = Parameters.Select(parameter=> new Item(parameter.ToString(),new List<Item>())).ToList();
        var attributes = Attributes.Select(attribute=> new Item(attribute.ToString(),new List<Item>())).ToList();
        childrens.AddRange(parameters);
        childrens.AddRange(attributes);
        return new($"Task : {Title}",childrens);    
    }    
}
