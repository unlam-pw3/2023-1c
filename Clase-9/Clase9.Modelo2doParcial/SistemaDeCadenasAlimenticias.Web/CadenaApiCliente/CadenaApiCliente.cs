namespace SistemaDeCadenasAlimenticias.Web.CadenaApiCliente
{
    public interface ICadenaApiCliente
    {
        Task<List<CadenaApiModel>> ObtenerCadenas();
    }
    public class CadenaApiCliente:ICadenaApiCliente
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CadenaApiCliente(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<List<CadenaApiModel>> ObtenerCadenas()
        {
            var clienteConexion = _httpClientFactory.CreateClient("CadenasAlimenticiasApiCliente");
            var response = await clienteConexion.GetAsync("/api/cadena");
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadFromJsonAsync<List<CadenaApiModel>>();
            return data;
        }

    }
}
