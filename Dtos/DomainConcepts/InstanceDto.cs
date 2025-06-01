namespace MDDPlatform.APIClient.Dtos.DomainConcepts
{
    public class InstanceDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public InstanceDto(Guid id, string name, string type)
        {
            Id = id;
            Name = name;
            Type = type;
        }
    }
}