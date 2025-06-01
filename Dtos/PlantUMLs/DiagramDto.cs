namespace MDDPlatform.APIClient.Dtos.PlantUMLs;
public class DiagramDto
{
    public string Title {get;set;}
    public string Code {get;set;}
    public string URLComponent {get; set;}
    public string SVGImageUrl  {get; set;}
    public string PNGImageUrl  {get; set;}

    public DiagramDto(string title, string code, string uRLComponent, string sVGImageUrl, string pNGImageUrl)
    {
        Title = title;
        Code = code;
        URLComponent = uRLComponent;
        SVGImageUrl = sVGImageUrl;
        PNGImageUrl = pNGImageUrl;
    }
}