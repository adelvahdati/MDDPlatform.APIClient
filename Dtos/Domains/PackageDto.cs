namespace MDDPlatform.APIClient.Dtos.Domains;
public class PackageDto{
    public Guid Id {get;set;}
    public string Title {get;set;}
    public List<ModelTemplateDto> ModelTemplates {get;set;}

    public PackageDto(Guid id, string title, List<ModelTemplateDto> modelTemplates)
    {
        Id = id;
        Title = title;
        ModelTemplates = modelTemplates;
    }
}
