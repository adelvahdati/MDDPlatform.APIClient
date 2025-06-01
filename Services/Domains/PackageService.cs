using MDDPlatform.APIClient.Dtos.Domains;
using MDDPlatform.APIClient.Services.Rest;

namespace MDDPlatform.APIClient.Services.Domains;

public class PackageService : IPackageService
{
    private readonly IRestClient _restClient;

    public PackageService(HttpClient httpClient)
    {
        _restClient = new RestClient(httpClient);
    }

    public async Task CreatePackageAsync(NewPackageDto package)
    {
        var url = string.Format("Package");
        await _restClient.PostAsync(url,package);
        
    }

    public async Task CreatePackageFromDomainAsync(Guid domainId, string title)
    {
        var url = string.Format("Package/Domain/{0}/{1}",domainId,title);
        await _restClient.PostAsync(url);
    }

    public async Task CreateModelsFromPackage(Guid packageId, Guid domainId)
    {
        var url = string.Format("Package/{0}/Domain/{1}",packageId,domainId);
        await _restClient.PostAsync(url);
    }

    public async Task<PackageDto?> GetAsync(Guid Id)
    {
        var url = string.Format("Package/{0}",Id);
        return await _restClient.GetAsync<PackageDto?>(url);
    }

    public async Task<List<PackageDto>?> ListAsync()
    {
        var url = string.Format("Package");
        return await _restClient.GetAsync<List<PackageDto>?>(url);

    }

    public async Task DeletePackageAsync(Guid packageId)
    {
        var url = string.Format("Package/{0}",packageId);
        await _restClient.DeleteAsync(url);
    }

    public async Task ImportPackagesAsync()
    {
        string url = "Data/Seed";
         await _restClient.PostAsync(url);
    }
}