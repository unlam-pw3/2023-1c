namespace SistemaDeCadenasAlimenticias.Web.CadenaApiCliente
{
    public interface ICadenaApiCliente
    {
        Task<HttpResponseMessage> CrearCadena(CadenaApiModel cadena);
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
            var response = await clienteConexion.GetAsync("/api/cadena/");
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadFromJsonAsync<List<CadenaApiModel>>();
            return data;
        }

        public async Task<HttpResponseMessage> CrearCadena(CadenaApiModel cadena)
        {
            var client = _httpClientFactory.CreateClient("CadenasAlimenticiasApiCliente");
            var response = await client.PostAsJsonAsync("/api/cadena",cadena);
            //response.EnsureSuccessStatusCode();
            return response;
        }





    }
}
