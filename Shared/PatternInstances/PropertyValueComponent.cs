using System.Text.Json;
using System.Text.Json.Serialization;
using MDDPlatform.APIClient.Dtos.PatternInstances;
using Microsoft.AspNetCore.Components;

namespace MDDPlatform.APIClient.Shared.PatternInstances;
public partial class PropertyValueComponent
{
    [Parameter]
    public EventCallback<List<MemberValueExpression>> MemberValuesChanged {get;set;}

    [Parameter]
    public EventCallback<string> TextChanged {get;set;}

    [Parameter]
    public List<MemberValueExpression> MemberValues 
    {
        get=> _memberValues;
        set
        {
            if(_memberValues == value || value == null) return;
            _memberValues = value;
            MemberValuesChanged.InvokeAsync(value);            
        }
    }

    private List<MemberValueExpression> _memberValues;
    private string _text;
    private string _property_name = "";
    private string _valueExpression = "";
    public void SetPropertyValue()
    {
        if(MemberValues == null)
            MemberValues = new();
        if(!string.IsNullOrEmpty(_property_name.Trim()))
        {
            
            _memberValues.Add(new MemberValueExpression(_property_name,_valueExpression));
            TextChanged.InvokeAsync(JsonSerializer.Serialize(_memberValues));            
            _property_name = "";
            _valueExpression = "";
        }                    
    }
    public void DeletePropertyValue(MemberValueExpression item)
    {
        _memberValues.Remove(item);
        TextChanged.InvokeAsync(JsonSerializer.Serialize(_memberValues));
    }

}