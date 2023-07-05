namespace Clase8.Jugueteria.MVC.ApiClients;

public interface IJuguetesApiClient
{
    Task<List<JugueteApiModel>> ObtenerJuguetes();
    Task<JugueteApiModel> ObtenerJuguete(int id);
}
public class JuguetesApiClient : IJuguetesApiClient
{
    private readonly IHttpClientFactory _httpClientFactory;

    public JuguetesApiClient(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<List<JugueteApiModel>> ObtenerJuguetes()
    {
        var client = _httpClientFactory.CreateClient("JuguetesApiClient");
        var response = await client.GetAsync("/api/juguetes");
        response.EnsureSuccessStatusCode();

        var data = await response.Content.ReadFromJsonAsync<List<JugueteApiModel>>();
        return data;
    }
    public async Task<JugueteApiModel> ObtenerJuguete(int id)
    {
        var client = _httpClientFactory.CreateClient("JuguetesApiClient");
        var response = await client.GetAsync($"/api/juguetes/{id}");
        response.EnsureSuccessStatusCode();

        var data = await response.Content.ReadFromJsonAsync<JugueteApiModel>();
        return data;
    }

}
