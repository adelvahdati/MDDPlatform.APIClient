using MDDPlatform.APIClient.Dtos.Concepts;
using MDDPlatform.APIClient.Services.Rest;

namespace MDDPlatform.APIClient.Services.Concepts;
public class ConceptService : IConceptService
{
    private readonly IRestClient restClient;

    // public ConceptService(IRestClient restClient)
    // {
    //     this.restClient = restClient;
    // }
    public ConceptService(HttpClient httpClient)
    {
        this.restClient = new RestClient(httpClient);
    }
    public Task AddConceptPropertyAsync(Guid conceptId, string name, string type)
    {
        throw new NotImplementedException();
    }

    public Task AddConceptRelationAsync(Guid conceptId, string name, string target, string multiplicity)
    {
        throw new NotImplementedException();
    }

    public Task CreateConceptAsync(NewConceptDto concept)
    {
        return restClient.PostAsync("Concept/Create",concept);
    }

    public Task CreateEmptyConceptAsync(string name, string type)
    {
        throw new NotImplementedException();
    }

    public Task DeleteConceptAsync(Guid ConceptId){
        var uri = string.Format("Concept/Delete/{0}",ConceptId);
        Console.WriteLine(uri);
        return restClient.DeleteAsync(uri);
    }

    public Task<IEnumerable<ConceptDto>?> FindConceptsByType(string type)
    {
        throw new NotImplementedException();
    }

    public Task<PropertyDto?> FindPropertyByName(Guid conceptId, string propertyName)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ConceptDto>?> FindRelatedConcepts(Guid conceptId)
    {
        throw new NotImplementedException();
    }

    public Task<RelationDto?> FindRelation(Guid conceptId, string relationName, string target)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<RelationDto>?> FindRelationByNameAsync(Guid conceptId, string relationName)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<RelationDto>?> FindRelationByTargetAsync(Guid conceptId, string target)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ConceptDto>?> FindTargetConcepts(Guid conceptId, string relationName)
    {
        throw new NotImplementedException();
    }

    public Task<ConceptDto?> GetConceptAsync(Guid conceptId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ConceptDto>?> GetConceptsAsync(Guid[] conceptIds)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ConceptDto>?> GetConceptsAsync()
    {
        return restClient.GetAsync<IEnumerable<ConceptDto>?>("Concept/list");

    }

    public Task<IEnumerable<PropertyDto>?> GetProperties(Guid conceptId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<RelationDto>?> GetRelationsAsync(Guid conceptId)
    {
        throw new NotImplementedException();
    }
}