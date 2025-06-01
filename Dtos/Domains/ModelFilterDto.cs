using MDDPlatform.APIClient.Dtos.Common;

namespace MDDPlatform.APIClient.Dtos.Domains;
public class ModelFilterDto{
    public FilterDto<Guid> FilterByProblemDomain {get;set;}
    public FilterDto<Guid> FilterByDomain {get;set;}
    public FilterDto<string> FilterByName {get;set;}
    public FilterDto<string> FilterByAbstractionLevel {get;set;}
    public FilterDto<string> FilterByTag {get;set;}
    public FilterDto<Guid> FilterByLnaguage {get;set;}

    public ModelFilterDto()
    {
        FilterByProblemDomain = FilterDto<Guid>.DontCare();
        FilterByDomain = FilterDto<Guid>.DontCare();
        FilterByName =FilterDto<string>.DontCare();
        FilterByAbstractionLevel = FilterDto<string>.DontCare();
        FilterByTag = FilterDto<string>.DontCare();
        FilterByLnaguage = FilterDto<Guid>.DontCare();
    }
    public void SetProblemDomain(Guid id){
        FilterByProblemDomain = FilterDto<Guid>.Create(id);
    }
    public void ResetProblemDomain()
    {
        FilterByProblemDomain = FilterDto<Guid>.DontCare();
    }
    public void SetDomain(Guid id){
        FilterByDomain = FilterDto<Guid>.Create(id);
    }
    public void ResetDomain(){
        FilterByDomain = FilterDto<Guid>.DontCare();
    }
    public void SetLanguage(Guid id){
        FilterByLnaguage = FilterDto<Guid>.Create(id);
    }
    public void ResetLanguage(){
        FilterByLnaguage = FilterDto<Guid>.DontCare();
    }
    public void SetName(string value)
    {
        FilterByName = FilterDto<string>.Create(value);
    }
    public void ResetName(){
        FilterByName = FilterDto<string>.DontCare();
    }

    public void SetType(string value)
    {
        FilterByAbstractionLevel = FilterDto<string>.Create(value);
    }
    public void ResetType(){
        FilterByAbstractionLevel = FilterDto<string>.DontCare();
    }
    public void SetTag(string value)
    {
        FilterByTag = FilterDto<string>.Create(value);
    }
    public void ResetTag(){
        FilterByTag = FilterDto<string>.DontCare();
    }
}