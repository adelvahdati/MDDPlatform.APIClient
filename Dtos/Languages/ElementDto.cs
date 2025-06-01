using MDDPlatform.APIClient.Dtos.Concepts;

namespace MDDPlatform.APIClient.Dtos.Languages
{
    public class ElementDto {
        public Guid Id {get;set;}
        public string Name {get; set;}
        public string Type {get; set;}

        public ElementDto(Guid id, string name, string type)
        {
            Id = id;
            Name = name;
            Type = type;
        }
        public static ElementDto CreateFrom(ConceptDto concept){
            return new ElementDto(concept.Id,concept.Name,concept.Type);
        }

    }
}