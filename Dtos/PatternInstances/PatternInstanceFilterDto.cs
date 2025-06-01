using MDDPlatform.APIClient.Dtos.Common;

namespace MDDPlatform.APIClient.Dtos.PatternInstances;

public class PatternInstanceFilterDto
{

    public FilterDto<Guid> FilterByProblemDomain { get; set; }
    public FilterDto<Guid> FilterByInputMetaModel { get; set; }
    public FilterDto<Guid> FilterByOutputMetamodel { get; set; }
    public FilterDto<string> FilterByInputModelType { get; set; }
    public FilterDto<string> FilterByOutputModelType { get; set; }

    public PatternInstanceFilterDto()
    {
        FilterByProblemDomain = FilterDto<Guid>.DontCare();
        FilterByInputMetaModel = FilterDto<Guid>.DontCare();
        FilterByOutputMetamodel = FilterDto<Guid>.DontCare();
        FilterByInputModelType = FilterDto<string>.DontCare();
        FilterByOutputModelType = FilterDto<string>.DontCare();

    }
    public void SetProblemDomain(Guid id){
        FilterByProblemDomain = FilterDto<Guid>.Create(id);
    }
    public void ResetProblemDomain()
    {
        FilterByProblemDomain = FilterDto<Guid>.DontCare();
    }

    public void SetInputMetaModel(Guid id){
        FilterByInputMetaModel = FilterDto<Guid>.Create(id);
    }
    public void ResetInputMetaModel()
    {
        FilterByInputMetaModel = FilterDto<Guid>.DontCare();
    }
    public void SetOutputMetaModel(Guid id){
        FilterByOutputMetamodel = FilterDto<Guid>.Create(id);
    }
    public void ResetOutputMetaModel()
    {
        FilterByOutputMetamodel = FilterDto<Guid>.DontCare();
    }
    public void SetInputModelType(string type){
        FilterByInputModelType = FilterDto<string>.Create(type);
    }
    public void ResetInputModelType()
    {
        FilterByInputModelType = FilterDto<string>.DontCare();
    }
    public void SetOutputModelType(string type){
        FilterByOutputModelType = FilterDto<string>.Create(type);
    }
    public void ResetOutputModelType()
    {
        FilterByOutputModelType = FilterDto<string>.DontCare();
    }

}
