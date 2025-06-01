namespace MDDPlatform.APIClient.Dtos.Processes;
public class TaskAttributeDto
{
    public string Name { get; set; }
    public string Value { get; set; }

    public TaskAttributeDto(string name, string value)
    {
        this.Name = name;
        this.Value = value;
    }
    public override string ToString()
    {
        var value = Value;
        if(string.IsNullOrEmpty(Value))
            value = "\"\"";
        return string.Format("{0} = {1}",Name,value);
    }
}