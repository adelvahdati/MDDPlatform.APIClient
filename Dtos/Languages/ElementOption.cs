using MDDPlatform.APIClient.Dtos.Concepts;

namespace MDDPlatform.APIClient.Dtos.Languages;
public class ElementOption
{
    public ElementDto Element {get;set;}
    public bool IsSelected {get;set;}

    public ElementOption(ElementDto element, bool isSelected)
    {
        Element = element;
        IsSelected = isSelected;
    }
    public static ElementOption CreateFrom(ConceptDto concept)
    {
        var element = ElementDto.CreateFrom(concept);
        return new ElementOption(element,false);
    }
    public ElementOption DeselectElement(){
        return new(Element,false);
    }
}