namespace LoginRegisterAuthentication.Models
{
    public class UserDto
    {
        public required string Username { get; set; } = string.Empty;
        public required string Passwor { get; set; } = string.Empty;
    }
}
