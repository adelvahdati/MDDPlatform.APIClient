namespace MDDPlatform.APIClient.Services.ProjectFileServices;
public class ProjectFileService : IProjectFileService
{
    private readonly IConfiguration configuration;

    public ProjectFileService(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    public string GetProjectFileUrl(Guid DomainModelId)
    {
        var baseUrl = configuration["Services:TransformationService"];
        var url= string.Format("{0}/CodeGenerator/download/{1}",baseUrl,DomainModelId);
        return url;
    }
}
