namespace MDDPlatform.APIClient.Services.Rest;
public interface IRestClient
{
    Task<HttpResponseMessage> PostAsync(string uri,object date);
    Task<HttpResponseMessage> PostAsync(string uri);
    Task<T?> PostAsync<T>(string uri, object data);
    Task<T?> GetAsync<T>(string url);
    Task<HttpResponseMessage> DeleteAsync(string uri);
}