namespace MDDPlatform.APIClient.Dtos.DomainObjects
{
    public class RelationalDimensionDto
    {
        public string Name { get; set; }
        public string Target { get; set; }

        public RelationalDimensionDto(string name, string target)
        {
            Name = name;
            Target = target;
        }
    }
}