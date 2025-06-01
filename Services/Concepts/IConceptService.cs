
using MDDPlatform.APIClient.Dtos.Concepts;

namespace MDDPlatform.APIClient.Services.Concepts;
public interface IConceptService
{
    //Commands
    Task CreateEmptyConceptAsync(string name,string type);
    Task CreateConceptAsync(NewConceptDto concept);

    Task AddConceptPropertyAsync(Guid conceptId, string name, string type);
    Task AddConceptRelationAsync(Guid conceptId, string name, string target, string multiplicity);
    
    Task DeleteConceptAsync(Guid ConceptId);

    //Query Concepts
    Task<ConceptDto?> GetConceptAsync(Guid conceptId);
    Task<IEnumerable<ConceptDto>?> GetConceptsAsync(Guid[] conceptIds);
    Task<IEnumerable<ConceptDto>?> GetConceptsAsync();
    Task<IEnumerable<ConceptDto>?> FindConceptsByType(string type);
    Task<IEnumerable<ConceptDto>?> FindRelatedConcepts(Guid conceptId);
    Task<IEnumerable<ConceptDto>?> FindTargetConcepts(Guid conceptId,string relationName);


    //Query Concept Properties
    Task<IEnumerable<PropertyDto>?> GetProperties(Guid conceptId);
    Task<PropertyDto?> FindPropertyByName(Guid conceptId, string propertyName);


    //Query Concept Relations
    Task<IEnumerable<RelationDto>?> GetRelationsAsync(Guid conceptId);
    Task<IEnumerable<RelationDto>?> FindRelationByNameAsync(Guid conceptId, string relationName);
    Task<IEnumerable<RelationDto>?> FindRelationByTargetAsync(Guid conceptId, string target);
    Task<RelationDto?> FindRelation(Guid conceptId, string relationName,string target);
    
}