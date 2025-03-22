using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using omniBridge_microservices_register.Data.Dtos;
using omniBridge_microservices_register.httpClient;


namespace omniBridge_microservices_register.Controllers
{
    [ApiController]
    [Route("api/address")]
    public class AddressController : ControllerBase
    {
        private readonly IViaCepServiceHttpClient _viaCepService;
        private IMapper _mapper;

        public AddressController(IViaCepServiceHttpClient viaCepService, IMapper mapper)
        {
            _viaCepService = viaCepService;
            _mapper = mapper;
        }

        [HttpGet("{cep}")]
        public async Task<IActionResult> GetAddressByCep(string cep)
        {
            if (string.IsNullOrWhiteSpace(cep) || cep.Length != 8 || !int.TryParse(cep, out _))
            {
                return BadRequest("CEP inválido. Certifique-se de que possui 8 dígitos numéricos.");
            }

            var address = await _viaCepService.GetAddressByCep(int.Parse(cep));

            var addressResponse = _mapper.Map<ResultAddressViaCepDto>(address);

            if (address == null)
            {
                return NotFound("Endereço não encontrado para o CEP informado.");
            }

            return Ok(addressResponse);
        }
    }
}
