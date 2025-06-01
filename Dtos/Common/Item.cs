namespace MDDPlatform.APIClient.Dtos.Common;
public class Item
{
    public string Text {get;set;}
    public IEnumerable<Item> Children {get;set;}

    public Item(string text, IEnumerable<Item> children)
    {
        Text = text;
        Children = children;
    }
}