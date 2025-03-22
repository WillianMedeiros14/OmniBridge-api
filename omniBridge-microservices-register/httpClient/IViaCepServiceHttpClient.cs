using omniBridge_microservices_register.Data.Dtos;

namespace omniBridge_microservices_register.httpClient
{
    public interface IViaCepServiceHttpClient
    {
        Task<ResultViaCepDto> GetAddressByCep(int cep);
    }
}
