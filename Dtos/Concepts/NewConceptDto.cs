namespace MDDPlatform.APIClient.Dtos.Concepts;
public class NewConceptDto
{
        public string Name {get;set;}
        public string Type {get;set;}
        public List<PropertyDto> Properties {get;set;}
        public List<RelationDto> Relations {get;set;}

    public NewConceptDto(string name, string type, List<PropertyDto> properties, List<RelationDto> relations)
    {
        Name = name;
        Type = type;
        Properties = properties;
        Relations = relations;
    }
    public NewConceptDto(){
        Name ="";
        Type = "";
        Properties = new List<PropertyDto>();
        Relations = new List<RelationDto>();
    }
    public void AddProperty(string propertyName,string propertyType){
        PropertyDto prop = new PropertyDto(propertyName,propertyType);
        Properties.Add(prop);
    }
    public void AddRelation(string relationName,string target,string multiplicity){
        RelationDto relation = new RelationDto(relationName,target,multiplicity);
        Relations.Add(relation);
    }
}