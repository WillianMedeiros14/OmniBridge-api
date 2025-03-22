namespace omniBridge_microservices_register.Data.Dtos
{
    public class LoginResponseDto
    {
        public string Token { get; set; }
        public UserInfoDto User { get; set; }
    }
}
