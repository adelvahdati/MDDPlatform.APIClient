namespace MDDPlatform.APIClient.Dtos.Domains;
public class ModelLanguageDto 
{
    public Guid Id {get; set;}
    public string Name {get;  set;}
    public bool IsBuiltin {get;set;}

    public ModelLanguageDto( Guid id, string name,bool isBuiltin)
    {
        this.Id = id;
        this.Name = name;
        IsBuiltin = isBuiltin;
    }
    public ModelLanguageDto( Guid id, string name)
    {
        this.Id = id;
        this.Name = name;
    }
    public ModelLanguageDto(){
        Id = Guid.Empty;
        Name = string.Empty;
        IsBuiltin = false;
    }
}