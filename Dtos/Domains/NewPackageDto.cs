namespace MDDPlatform.APIClient.Dtos.Domains;

public class NewPackageDto
{
    public string Title {get;set;}
    public List<ModelTemplateDto> ModelTemplates {get;set;}

    public NewPackageDto(string title, List<ModelTemplateDto> modelTemplates)
    {
        Title = title;
        ModelTemplates = modelTemplates;
    }
}
