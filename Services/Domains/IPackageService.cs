using MDDPlatform.APIClient.Dtos.Domains;

namespace MDDPlatform.APIClient.Services.Domains;
public interface IPackageService
{
    Task CreatePackageAsync(NewPackageDto package);
    Task CreatePackageFromDomainAsync(Guid DomainId,string title);
    Task CreateModelsFromPackage(Guid packageId,Guid domainId);
    Task<PackageDto?> GetAsync(Guid layerId);
    Task<List<PackageDto>?> ListAsync();
    Task DeletePackageAsync(Guid packageId);
    Task ImportPackagesAsync();
}