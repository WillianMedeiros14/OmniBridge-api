using System.Text.Json;
using System.Net;
using omniBridge_microservices_register.httpClient;
using omniBridge_microservices_register.Data.Dtos;

namespace omniBridge_microservices_register.ItemServiceHttpClient
{
    public class ViaCepServiceHttpClient : IViaCepServiceHttpClient
    {
        private readonly HttpClient _client;


        public ViaCepServiceHttpClient(HttpClient client, IConfiguration configuration)
        {
            _client = client;
        }

        public async Task<ResultViaCepDto> GetAddressByCep(int cep)
        {
            try
            {
                string url = $"https://viacep.com.br/ws/{cep}/json";

                HttpResponseMessage response = await _client.GetAsync(url);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var result = JsonSerializer.Deserialize<ResultViaCepDto>(jsonResponse, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    return result;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Erro ao buscar o endereço pelo CEP {cep}: {ex.Message}");
            }
        }
    }
}
